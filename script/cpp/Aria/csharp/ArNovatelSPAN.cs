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

public class ArNovatelSPAN : ArNovatelGPS {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  public ArNovatelSPAN(global::System.IntPtr cPtr, bool cMemoryOwn) : base(AriaCSPINVOKE.ArNovatelSPAN_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArNovatelSPAN obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArNovatelSPAN() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArNovatelSPAN(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public double GPSLatitude {
    set {
      AriaCSPINVOKE.ArNovatelSPAN_GPSLatitude_set(swigCPtr, value);
    } 
    get {
      double ret = AriaCSPINVOKE.ArNovatelSPAN_GPSLatitude_get(swigCPtr);
      return ret;
    } 
  }

  public double GPSLongitude {
    set {
      AriaCSPINVOKE.ArNovatelSPAN_GPSLongitude_set(swigCPtr, value);
    } 
    get {
      double ret = AriaCSPINVOKE.ArNovatelSPAN_GPSLongitude_get(swigCPtr);
      return ret;
    } 
  }

  public bool haveGPSPosition {
    set {
      AriaCSPINVOKE.ArNovatelSPAN_haveGPSPosition_set(swigCPtr, value);
    } 
    get {
      bool ret = AriaCSPINVOKE.ArNovatelSPAN_haveGPSPosition_get(swigCPtr);
      return ret;
    } 
  }

  public bool GPSValidFlag {
    set {
      AriaCSPINVOKE.ArNovatelSPAN_GPSValidFlag_set(swigCPtr, value);
    } 
    get {
      bool ret = AriaCSPINVOKE.ArNovatelSPAN_GPSValidFlag_get(swigCPtr);
      return ret;
    } 
  }

  public ArTime timeGotGPSPosition {
    set {
      AriaCSPINVOKE.ArNovatelSPAN_timeGotGPSPosition_set(swigCPtr, ArTime.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = AriaCSPINVOKE.ArNovatelSPAN_timeGotGPSPosition_get(swigCPtr);
      ArTime ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArTime(cPtr, false);
      return ret;
    } 
  }

  public ArTime GPSTimestamp {
    set {
      AriaCSPINVOKE.ArNovatelSPAN_GPSTimestamp_set(swigCPtr, ArTime.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = AriaCSPINVOKE.ArNovatelSPAN_GPSTimestamp_get(swigCPtr);
      ArTime ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArTime(cPtr, false);
      return ret;
    } 
  }

  public ArNovatelSPAN() : this(AriaCSPINVOKE.new_ArNovatelSPAN(), true) {
  }

}

}
