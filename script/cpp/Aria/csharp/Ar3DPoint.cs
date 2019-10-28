//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.8
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace AriaCS {

public class Ar3DPoint : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public Ar3DPoint(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(Ar3DPoint obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Ar3DPoint() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_Ar3DPoint(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public Ar3DPoint() : this(AriaCSPINVOKE.new_Ar3DPoint__SWIG_0(), true) {
  }

  public Ar3DPoint(double x, double y, double z) : this(AriaCSPINVOKE.new_Ar3DPoint__SWIG_1(x, y, z), true) {
  }

  public double dot(Ar3DPoint c) {
    double ret = AriaCSPINVOKE.Ar3DPoint_dot(swigCPtr, Ar3DPoint.getCPtr(c));
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Ar3DPoint cross(Ar3DPoint c) {
    Ar3DPoint ret = new Ar3DPoint(AriaCSPINVOKE.Ar3DPoint_cross(swigCPtr, Ar3DPoint.getCPtr(c)), true);
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void print(string head) {
    AriaCSPINVOKE.Ar3DPoint_print__SWIG_0(swigCPtr, head);
  }

  public void print() {
    AriaCSPINVOKE.Ar3DPoint_print__SWIG_1(swigCPtr);
  }

  public double getX() {
    double ret = AriaCSPINVOKE.Ar3DPoint_getX(swigCPtr);
    return ret;
  }

  public double getY() {
    double ret = AriaCSPINVOKE.Ar3DPoint_getY(swigCPtr);
    return ret;
  }

  public double getZ() {
    double ret = AriaCSPINVOKE.Ar3DPoint_getZ(swigCPtr);
    return ret;
  }

  public void setX(double x) {
    AriaCSPINVOKE.Ar3DPoint_setX(swigCPtr, x);
  }

  public void setY(double y) {
    AriaCSPINVOKE.Ar3DPoint_setY(swigCPtr, y);
  }

  public void setZ(double z) {
    AriaCSPINVOKE.Ar3DPoint_setZ(swigCPtr, z);
  }

}

}