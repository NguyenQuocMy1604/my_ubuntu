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

public class ArWGS84 : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public ArWGS84(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArWGS84 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArWGS84() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArWGS84(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public ArWGS84() : this(AriaCSPINVOKE.new_ArWGS84(), true) {
  }

  public static double getE() {
    double ret = AriaCSPINVOKE.ArWGS84_getE();
    return ret;
  }

  public static double getA() {
    double ret = AriaCSPINVOKE.ArWGS84_getA();
    return ret;
  }

  public static double getB() {
    double ret = AriaCSPINVOKE.ArWGS84_getB();
    return ret;
  }

  public static double getEP() {
    double ret = AriaCSPINVOKE.ArWGS84_getEP();
    return ret;
  }

  public static double get1byf() {
    double ret = AriaCSPINVOKE.ArWGS84_get1byf();
    return ret;
  }

  public static double getOmega() {
    double ret = AriaCSPINVOKE.ArWGS84_getOmega();
    return ret;
  }

  public static double getGM() {
    double ret = AriaCSPINVOKE.ArWGS84_getGM();
    return ret;
  }

}

}