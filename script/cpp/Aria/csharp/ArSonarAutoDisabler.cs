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

public class ArSonarAutoDisabler : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public ArSonarAutoDisabler(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArSonarAutoDisabler obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArSonarAutoDisabler() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArSonarAutoDisabler(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public ArSonarAutoDisabler(ArRobot robot) : this(AriaCSPINVOKE.new_ArSonarAutoDisabler(ArRobot.getCPtr(robot)), true) {
  }

  public void supress() {
    AriaCSPINVOKE.ArSonarAutoDisabler_supress(swigCPtr);
  }

  public ArFunctor getSupressCallback() {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArSonarAutoDisabler_getSupressCallback(swigCPtr);
    ArFunctor ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArFunctor(cPtr, false);
    return ret;
  }

  public void unsupress() {
    AriaCSPINVOKE.ArSonarAutoDisabler_unsupress(swigCPtr);
  }

  public ArFunctor getUnsupressCallback() {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArSonarAutoDisabler_getUnsupressCallback(swigCPtr);
    ArFunctor ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArFunctor(cPtr, false);
    return ret;
  }

  public void setAutonomousDriving() {
    AriaCSPINVOKE.ArSonarAutoDisabler_setAutonomousDriving(swigCPtr);
  }

  public ArFunctor getSetAutonomousDrivingCallback() {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArSonarAutoDisabler_getSetAutonomousDrivingCallback(swigCPtr);
    ArFunctor ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArFunctor(cPtr, false);
    return ret;
  }

  public void clearAutonomousDriving() {
    AriaCSPINVOKE.ArSonarAutoDisabler_clearAutonomousDriving(swigCPtr);
  }

  public ArFunctor getClearAutonomousDrivingCallback() {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArSonarAutoDisabler_getClearAutonomousDrivingCallback(swigCPtr);
    ArFunctor ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArFunctor(cPtr, false);
    return ret;
  }

}

}
