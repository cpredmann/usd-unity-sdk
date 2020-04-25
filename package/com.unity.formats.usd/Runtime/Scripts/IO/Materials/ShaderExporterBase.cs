﻿// Copyright 2018 Jeremy Cowles. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using pxr;
using UnityEngine;
using USD.NET;
using USD.NET.Unity;

namespace Unity.Formats.USD {

  public class ShaderExporterBase {

    /// <summary>
    /// Exports the given texture to the destination texture path and wires up the preview surface.
    /// </summary>
    /// <returns>
    /// Returns the path to the USD texture object.
    /// </returns>
    protected static string SetupTexture(Scene scene,
                                 string usdShaderPath,
                                 Material material,
                                 PreviewSurfaceSample surface,
                                 Vector4 scale,
                                 string destTexturePath,
                                 string textureName,
                                 string textureOutput)
    {
      // We have to handle multiple cases here:
      // - file exists on disk
      //   - file is a supported format => can be directly copied
      //   - file is not in a supported format => need to blit / export
      // - file is only in memory
      //   - a Texture2D
      //   - a Texture
      //   - a RenderTexture
      //   - needs special care if marked as Normal Map
      //     (can probably only be detected in an Editor context, and heuristically at runtime)
      //   => need to blit / export
      // - file is not supported at all (or not yet)
      //   - a 3D texture
      //   => needs to be ignored, log Warning

      bool textureIsExported = false;

      string filePath = null;
      string fileName = null;

      var texture = material.GetTexture(textureName);

  #if UNITY_EDITOR
      var srcPath = UnityEditor.AssetDatabase.GetAssetPath(texture);
      if(!string.IsNullOrEmpty(srcPath))
      { 
        srcPath = srcPath.Substring("Assets/".Length);
        srcPath = Application.dataPath + "/" + srcPath;
        fileName = System.IO.Path.GetFileName(srcPath);
        filePath = System.IO.Path.Combine(destTexturePath, fileName);

        if(System.IO.File.Exists(srcPath))
        { 
          // USDZ officially only supports png / jpg / jpeg
          // https://graphics.pixar.com/usd/docs/Usdz-File-Format-Specification.html

          var ext = System.IO.Path.GetExtension(srcPath).ToLowerInvariant();
          if(ext == ".png" || ext == ".jpg" || ext == ".jpeg") { 
            System.IO.File.Copy(srcPath, filePath, overwrite: true);
            if (System.IO.File.Exists(filePath))
              textureIsExported = true;
          }
        }
      }
  #endif
      if (!textureIsExported)
      {
        fileName = texture.name + "_" + Random.Range(10000000, 99999999).ToString();
  #if UNITY_EDITOR
        if (UnityEditor.AssetDatabase.Contains(texture))
          fileName = texture.name + "_png";
  #endif
        filePath = System.IO.Path.Combine(destTexturePath, fileName + ".png");
        
        // TODO extra care has to be taken of Normal Maps etc., since these are in a converted format in memory (for example 16 bit AG instead of 8 bit RGBA, depending on platform)
        // An example of this conversion in a shader is in Khronos' UnityGLTF implementation.
        // Basically, the blit has do be done with the right unlit conversion shader to get a proper "file-based" tangent space normal map back

        // Blit the texture and get it back to CPU
        // Note: Can't use RenderTexture.GetTemporary because that doesn't properly clear alpha channel
        var rt = new RenderTexture(texture.width, texture.height, 0, RenderTextureFormat.ARGB32);
        var resultTex = new Texture2D(texture.width, texture.height, TextureFormat.ARGB32, true);
        var activeRT = RenderTexture.active;
        try { 
          RenderTexture.active = rt;
          GL.Clear(true, true, Color.clear);
          Graphics.Blit(texture, rt);
          resultTex.ReadPixels(new Rect(0, 0, texture.width, texture.height), 0, 0);
          resultTex.Apply();

          System.IO.File.WriteAllBytes(filePath, resultTex.EncodeToPNG());
          if (System.IO.File.Exists(filePath))
            textureIsExported = true;
        }
        finally {
          RenderTexture.active = activeRT;
          rt.Release();
          GameObject.DestroyImmediate(rt);
          GameObject.DestroyImmediate(resultTex);
        }
      }

      if(!textureIsExported)
      {
        var tex = new Texture2D(1, 1, TextureFormat.ARGB32, true);
        try { 
          tex.SetPixel(0, 0, Color.white);
          tex.Apply();
          System.IO.File.WriteAllBytes(filePath, tex.EncodeToPNG());
          if (System.IO.File.Exists(filePath)) {
            textureIsExported = true;
          }
        }
        finally {
          GameObject.DestroyImmediate(tex);
        }
      }

      if(textureIsExported)
      { 
        // Make file path baked into USD relative to scene file and use forward slashes.
        filePath = ImporterBase.MakeRelativePath(scene.FilePath, filePath);
        filePath = filePath.Replace("\\", "/");

        var uvReader = new PrimvarReaderSample<Vector2>();
        uvReader.varname.defaultValue = new TfToken("st");
        scene.Write(usdShaderPath + "/uvReader", uvReader);
        var tex = new TextureReaderSample(filePath, usdShaderPath + "/uvReader.outputs:result");
        tex.wrapS = new Connectable<TextureReaderSample.WrapMode>(TextureReaderSample.GetWrapMode(texture2d.wrapModeU));
        tex.wrapT = new Connectable<TextureReaderSample.WrapMode>(TextureReaderSample.GetWrapMode(texture2d.wrapModeV));
        if(scale != Vector4.one) {
            tex.scale = new Connectable<Vector4>(scale);
        }
        scene.Write(usdShaderPath + "/" + textureName, tex);
        return usdShaderPath + "/" + textureName + ".outputs:" + textureOutput;
      }
      else {
        Debug.LogError("Texture wasn't exported: " + texture.name + " (" + textureName + " from material " + material, texture);
      }
    }
  }
}
