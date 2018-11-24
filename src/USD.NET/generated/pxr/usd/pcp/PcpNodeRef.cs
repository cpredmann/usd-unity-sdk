//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pxr {

public class PcpNodeRef : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PcpNodeRef(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PcpNodeRef obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PcpNodeRef() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_PcpNodeRef(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public PcpNodeRef() : this(UsdCsPINVOKE.new_PcpNodeRef(), true) {
  }

  public PcpArcType GetArcType() {
    PcpArcType ret = (PcpArcType)UsdCsPINVOKE.PcpNodeRef_GetArcType(swigCPtr);
    return ret;
  }

  public PcpNodeRef GetParentNode() {
    PcpNodeRef ret = new PcpNodeRef(UsdCsPINVOKE.PcpNodeRef_GetParentNode(swigCPtr), true);
    return ret;
  }

  public PcpNodeRef InsertChildSubgraph(SWIGTYPE_p_TfDeclarePtrsT_PcpPrimIndex_Graph_t__Ptr subgraph, PcpArc arc) {
    PcpNodeRef ret = new PcpNodeRef(UsdCsPINVOKE.PcpNodeRef_InsertChildSubgraph(swigCPtr, SWIGTYPE_p_TfDeclarePtrsT_PcpPrimIndex_Graph_t__Ptr.getCPtr(subgraph), PcpArc.getCPtr(arc)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PcpNodeRef GetOriginNode() {
    PcpNodeRef ret = new PcpNodeRef(UsdCsPINVOKE.PcpNodeRef_GetOriginNode(swigCPtr), true);
    return ret;
  }

  public PcpNodeRef GetOriginRootNode() {
    PcpNodeRef ret = new PcpNodeRef(UsdCsPINVOKE.PcpNodeRef_GetOriginRootNode(swigCPtr), true);
    return ret;
  }

  public PcpNodeRef GetRootNode() {
    PcpNodeRef ret = new PcpNodeRef(UsdCsPINVOKE.PcpNodeRef_GetRootNode(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_PcpMapExpression GetMapToParent() {
    SWIGTYPE_p_PcpMapExpression ret = new SWIGTYPE_p_PcpMapExpression(UsdCsPINVOKE.PcpNodeRef_GetMapToParent(swigCPtr), false);
    return ret;
  }

  public SWIGTYPE_p_PcpMapExpression GetMapToRoot() {
    SWIGTYPE_p_PcpMapExpression ret = new SWIGTYPE_p_PcpMapExpression(UsdCsPINVOKE.PcpNodeRef_GetMapToRoot(swigCPtr), false);
    return ret;
  }

  public int GetSiblingNumAtOrigin() {
    int ret = UsdCsPINVOKE.PcpNodeRef_GetSiblingNumAtOrigin(swigCPtr);
    return ret;
  }

  public int GetNamespaceDepth() {
    int ret = UsdCsPINVOKE.PcpNodeRef_GetNamespaceDepth(swigCPtr);
    return ret;
  }

  public int GetDepthBelowIntroduction() {
    int ret = UsdCsPINVOKE.PcpNodeRef_GetDepthBelowIntroduction(swigCPtr);
    return ret;
  }

  public SdfPath GetPathAtIntroduction() {
    SdfPath ret = new SdfPath(UsdCsPINVOKE.PcpNodeRef_GetPathAtIntroduction(swigCPtr), true);
    return ret;
  }

  public SdfPath GetIntroPath() {
    SdfPath ret = new SdfPath(UsdCsPINVOKE.PcpNodeRef_GetIntroPath(swigCPtr), true);
    return ret;
  }

  public SdfPath GetPath() {
    SdfPath ret = new SdfPath(UsdCsPINVOKE.PcpNodeRef_GetPath(swigCPtr), false);
    return ret;
  }

  public PcpLayerStack GetLayerStack() {
    global::System.IntPtr cPtr = UsdCsPINVOKE.PcpNodeRef_GetLayerStack(swigCPtr);
    PcpLayerStack ret = (cPtr == global::System.IntPtr.Zero) ? null : new PcpLayerStack(cPtr, true);
    return ret;
  }

  public bool IsDirect() {
    bool ret = UsdCsPINVOKE.PcpNodeRef_IsDirect(swigCPtr);
    return ret;
  }

  public bool IsDueToAncestor() {
    bool ret = UsdCsPINVOKE.PcpNodeRef_IsDueToAncestor(swigCPtr);
    return ret;
  }

  public void SetHasSymmetry(bool hasSymmetry) {
    UsdCsPINVOKE.PcpNodeRef_SetHasSymmetry(swigCPtr, hasSymmetry);
  }

  public bool HasSymmetry() {
    bool ret = UsdCsPINVOKE.PcpNodeRef_HasSymmetry(swigCPtr);
    return ret;
  }

  public void SetPermission(SdfPermission perm) {
    UsdCsPINVOKE.PcpNodeRef_SetPermission(swigCPtr, (int)perm);
  }

  public SdfPermission GetPermission() {
    SdfPermission ret = (SdfPermission)UsdCsPINVOKE.PcpNodeRef_GetPermission(swigCPtr);
    return ret;
  }

  public void SetInert(bool inert) {
    UsdCsPINVOKE.PcpNodeRef_SetInert(swigCPtr, inert);
  }

  public bool IsInert() {
    bool ret = UsdCsPINVOKE.PcpNodeRef_IsInert(swigCPtr);
    return ret;
  }

  public void SetCulled(bool culled) {
    UsdCsPINVOKE.PcpNodeRef_SetCulled(swigCPtr, culled);
  }

  public bool IsCulled() {
    bool ret = UsdCsPINVOKE.PcpNodeRef_IsCulled(swigCPtr);
    return ret;
  }

  public void SetRestricted(bool restricted) {
    UsdCsPINVOKE.PcpNodeRef_SetRestricted(swigCPtr, restricted);
  }

  public bool IsRestricted() {
    bool ret = UsdCsPINVOKE.PcpNodeRef_IsRestricted(swigCPtr);
    return ret;
  }

  public bool CanContributeSpecs() {
    bool ret = UsdCsPINVOKE.PcpNodeRef_CanContributeSpecs(swigCPtr);
    return ret;
  }

  public void SetHasSpecs(bool hasSpecs) {
    UsdCsPINVOKE.PcpNodeRef_SetHasSpecs(swigCPtr, hasSpecs);
  }

  public bool HasSpecs() {
    bool ret = UsdCsPINVOKE.PcpNodeRef_HasSpecs(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_Pcp_CompressedSdSite GetCompressedSdSite(uint layerIndex) {
    SWIGTYPE_p_Pcp_CompressedSdSite ret = new SWIGTYPE_p_Pcp_CompressedSdSite(UsdCsPINVOKE.PcpNodeRef_GetCompressedSdSite(swigCPtr, layerIndex), true);
    return ret;
  }

  public PcpNodeRefVector GetChildren() {
    PcpNodeRefVector ret = new PcpNodeRefVector(UsdCsPINVOKE.PcpNodeRef_GetChildren(swigCPtr), true);
    return ret;
  }

}

}
