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

public class GfBBox3d : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GfBBox3d(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(GfBBox3d obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~GfBBox3d() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_GfBBox3d(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public GfBBox3d() : this(UsdCsPINVOKE.new_GfBBox3d__SWIG_0(), true) {
  }

  public GfBBox3d(GfBBox3d rhs) : this(UsdCsPINVOKE.new_GfBBox3d__SWIG_1(GfBBox3d.getCPtr(rhs)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfBBox3d(GfRange3d box) : this(UsdCsPINVOKE.new_GfBBox3d__SWIG_2(GfRange3d.getCPtr(box)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfBBox3d(GfRange3d box, GfMatrix4d matrix) : this(UsdCsPINVOKE.new_GfBBox3d__SWIG_3(GfRange3d.getCPtr(box), GfMatrix4d.getCPtr(matrix)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Set(GfRange3d box, GfMatrix4d matrix) {
    UsdCsPINVOKE.GfBBox3d_Set(swigCPtr, GfRange3d.getCPtr(box), GfMatrix4d.getCPtr(matrix));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetMatrix(GfMatrix4d matrix) {
    UsdCsPINVOKE.GfBBox3d_SetMatrix(swigCPtr, GfMatrix4d.getCPtr(matrix));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(GfRange3d box) {
    UsdCsPINVOKE.GfBBox3d_SetRange(swigCPtr, GfRange3d.getCPtr(box));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfRange3d GetRange() {
    GfRange3d ret = new GfRange3d(UsdCsPINVOKE.GfBBox3d_GetRange(swigCPtr), false);
    return ret;
  }

  public GfRange3d GetBox() {
    GfRange3d ret = new GfRange3d(UsdCsPINVOKE.GfBBox3d_GetBox(swigCPtr), false);
    return ret;
  }

  public GfMatrix4d GetMatrix() {
    GfMatrix4d ret = new GfMatrix4d(UsdCsPINVOKE.GfBBox3d_GetMatrix(swigCPtr), false);
    return ret;
  }

  public GfMatrix4d GetInverseMatrix() {
    GfMatrix4d ret = new GfMatrix4d(UsdCsPINVOKE.GfBBox3d_GetInverseMatrix(swigCPtr), false);
    return ret;
  }

  public void SetHasZeroAreaPrimitives(bool hasThem) {
    UsdCsPINVOKE.GfBBox3d_SetHasZeroAreaPrimitives(swigCPtr, hasThem);
  }

  public bool HasZeroAreaPrimitives() {
    bool ret = UsdCsPINVOKE.GfBBox3d_HasZeroAreaPrimitives(swigCPtr);
    return ret;
  }

  public double GetVolume() {
    double ret = UsdCsPINVOKE.GfBBox3d_GetVolume(swigCPtr);
    return ret;
  }

  public void Transform(GfMatrix4d matrix) {
    UsdCsPINVOKE.GfBBox3d_Transform(swigCPtr, GfMatrix4d.getCPtr(matrix));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfRange3d ComputeAlignedRange() {
    GfRange3d ret = new GfRange3d(UsdCsPINVOKE.GfBBox3d_ComputeAlignedRange(swigCPtr), true);
    return ret;
  }

  public GfRange3d ComputeAlignedBox() {
    GfRange3d ret = new GfRange3d(UsdCsPINVOKE.GfBBox3d_ComputeAlignedBox(swigCPtr), true);
    return ret;
  }

  public static GfBBox3d Combine(GfBBox3d b1, GfBBox3d b2) {
    GfBBox3d ret = new GfBBox3d(UsdCsPINVOKE.GfBBox3d_Combine(GfBBox3d.getCPtr(b1), GfBBox3d.getCPtr(b2)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfVec3d ComputeCentroid() {
    GfVec3d ret = new GfVec3d(UsdCsPINVOKE.GfBBox3d_ComputeCentroid(swigCPtr), true);
    return ret;
  }

  public static bool Equals(GfBBox3d lhs, GfBBox3d rhs) {
    bool ret = UsdCsPINVOKE.GfBBox3d_Equals(GfBBox3d.getCPtr(lhs), GfBBox3d.getCPtr(rhs));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  override public int GetHashCode() {
    int ret = UsdCsPINVOKE.GfBBox3d_GetHashCode(swigCPtr);
    return ret;
  }

    public static bool operator==(GfBBox3d lhs, GfBBox3d rhs){
      // The Swig binding glue will re-enter this operator comparing to null, so 
      // that case must be handled explicitly to avoid an infinite loop. This is still
      // not great, since it crosses the C#/C++ barrier twice. A better approache might
      // be to return a simple value from C++ that can be compared in C#.
      bool lnull = lhs as object == null;
      bool rnull = rhs as object == null;
      return (lnull == rnull) && ((lnull && rnull) || GfBBox3d.Equals(lhs, rhs));
    }

    public static bool operator !=(GfBBox3d lhs, GfBBox3d rhs) {
        return !(lhs == rhs);
    }

    override public bool Equals(object rhs) {
      return GfBBox3d.Equals(this, rhs as GfBBox3d);
    }
  
}

}