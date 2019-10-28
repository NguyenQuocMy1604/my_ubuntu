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

public class ArLLACoords : Ar3DPoint {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  public ArLLACoords(global::System.IntPtr cPtr, bool cMemoryOwn) : base(AriaCSPINVOKE.ArLLACoords_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArLLACoords obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArLLACoords() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArLLACoords(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public ArLLACoords() : this(AriaCSPINVOKE.new_ArLLACoords__SWIG_0(), true) {
  }

  public ArLLACoords(double x, double y, double z) : this(AriaCSPINVOKE.new_ArLLACoords__SWIG_1(x, y, z), true) {
  }

  public ArLLACoords(ArPose pos, double alt) : this(AriaCSPINVOKE.new_ArLLACoords__SWIG_2(ArPose.getCPtr(pos), alt), true) {
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
  }

  public ArECEFCoords LLA2ECEF() {
    ArECEFCoords ret = new ArECEFCoords(AriaCSPINVOKE.ArLLACoords_LLA2ECEF(swigCPtr), true);
    return ret;
  }

  public double getLatitude() {
    double ret = AriaCSPINVOKE.ArLLACoords_getLatitude(swigCPtr);
    return ret;
  }

  public double getLongitude() {
    double ret = AriaCSPINVOKE.ArLLACoords_getLongitude(swigCPtr);
    return ret;
  }

  public double getAltitude() {
    double ret = AriaCSPINVOKE.ArLLACoords_getAltitude(swigCPtr);
    return ret;
  }

  public void setLatitude(double l) {
    AriaCSPINVOKE.ArLLACoords_setLatitude(swigCPtr, l);
  }

  public void setLongitude(double l) {
    AriaCSPINVOKE.ArLLACoords_setLongitude(swigCPtr, l);
  }

  public void setAltitude(double a) {
    AriaCSPINVOKE.ArLLACoords_setAltitude(swigCPtr, a);
  }

}

}