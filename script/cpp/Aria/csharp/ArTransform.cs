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

public class ArTransform : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public ArTransform(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArTransform obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArTransform() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArTransform(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public ArTransform() : this(AriaCSPINVOKE.new_ArTransform__SWIG_0(), true) {
  }

  public ArTransform(ArPose pose) : this(AriaCSPINVOKE.new_ArTransform__SWIG_1(ArPose.getCPtr(pose)), true) {
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
  }

  public ArTransform(ArPose pose1, ArPose pose2) : this(AriaCSPINVOKE.new_ArTransform__SWIG_2(ArPose.getCPtr(pose1), ArPose.getCPtr(pose2)), true) {
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
  }

  public ArPose doTransform(ArPose source) {
    ArPose ret = new ArPose(AriaCSPINVOKE.ArTransform_doTransform__SWIG_0(swigCPtr, ArPose.getCPtr(source)), true);
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ArPoseWithTime doTransform(ArPoseWithTime source) {
    ArPoseWithTime ret = new ArPoseWithTime(AriaCSPINVOKE.ArTransform_doTransform__SWIG_1(swigCPtr, ArPoseWithTime.getCPtr(source)), true);
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ArPose doInvTransform(ArPose source) {
    ArPose ret = new ArPose(AriaCSPINVOKE.ArTransform_doInvTransform__SWIG_0(swigCPtr, ArPose.getCPtr(source)), true);
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ArPoseWithTime doInvTransform(ArPoseWithTime source) {
    ArPoseWithTime ret = new ArPoseWithTime(AriaCSPINVOKE.ArTransform_doInvTransform__SWIG_1(swigCPtr, ArPoseWithTime.getCPtr(source)), true);
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void doTransform(SWIGTYPE_p_std__listT_ArPose_p_t poseList) {
    AriaCSPINVOKE.ArTransform_doTransform__SWIG_2(swigCPtr, SWIGTYPE_p_std__listT_ArPose_p_t.getCPtr(poseList));
  }

  public void doTransform(SWIGTYPE_p_std__listT_ArPoseWithTime_p_t poseList) {
    AriaCSPINVOKE.ArTransform_doTransform__SWIG_3(swigCPtr, SWIGTYPE_p_std__listT_ArPoseWithTime_p_t.getCPtr(poseList));
  }

  public void setTransform(ArPose pose) {
    AriaCSPINVOKE.ArTransform_setTransform__SWIG_0(swigCPtr, ArPose.getCPtr(pose));
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setTransform(ArPose pose1, ArPose pose2) {
    AriaCSPINVOKE.ArTransform_setTransform__SWIG_1(swigCPtr, ArPose.getCPtr(pose1), ArPose.getCPtr(pose2));
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
  }

  public double getX() {
    double ret = AriaCSPINVOKE.ArTransform_getX(swigCPtr);
    return ret;
  }

  public double getY() {
    double ret = AriaCSPINVOKE.ArTransform_getY(swigCPtr);
    return ret;
  }

  public double getTh() {
    double ret = AriaCSPINVOKE.ArTransform_getTh(swigCPtr);
    return ret;
  }

  public void setTransformLowLevel(double x, double y, double th) {
    AriaCSPINVOKE.ArTransform_setTransformLowLevel(swigCPtr, x, y, th);
  }

}

}
