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

public class ArGripper : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public ArGripper(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArGripper obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArGripper() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArGripper(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public ArGripper(ArRobot robot, int gripperType) : this(AriaCSPINVOKE.new_ArGripper__SWIG_0(ArRobot.getCPtr(robot), gripperType), true) {
  }

  public ArGripper(ArRobot robot) : this(AriaCSPINVOKE.new_ArGripper__SWIG_1(ArRobot.getCPtr(robot)), true) {
  }

  public bool gripOpen() {
    bool ret = AriaCSPINVOKE.ArGripper_gripOpen(swigCPtr);
    return ret;
  }

  public bool gripClose() {
    bool ret = AriaCSPINVOKE.ArGripper_gripClose(swigCPtr);
    return ret;
  }

  public bool gripStop() {
    bool ret = AriaCSPINVOKE.ArGripper_gripStop(swigCPtr);
    return ret;
  }

  public bool liftUp() {
    bool ret = AriaCSPINVOKE.ArGripper_liftUp(swigCPtr);
    return ret;
  }

  public bool liftDown() {
    bool ret = AriaCSPINVOKE.ArGripper_liftDown(swigCPtr);
    return ret;
  }

  public bool liftStop() {
    bool ret = AriaCSPINVOKE.ArGripper_liftStop(swigCPtr);
    return ret;
  }

  public bool gripperStore() {
    bool ret = AriaCSPINVOKE.ArGripper_gripperStore(swigCPtr);
    return ret;
  }

  public bool gripperDeploy() {
    bool ret = AriaCSPINVOKE.ArGripper_gripperDeploy(swigCPtr);
    return ret;
  }

  public bool gripperHalt() {
    bool ret = AriaCSPINVOKE.ArGripper_gripperHalt(swigCPtr);
    return ret;
  }

  public bool gripPressure(int mSecIntervals) {
    bool ret = AriaCSPINVOKE.ArGripper_gripPressure(swigCPtr, mSecIntervals);
    return ret;
  }

  public bool liftCarry(int mSecIntervals) {
    bool ret = AriaCSPINVOKE.ArGripper_liftCarry(swigCPtr, mSecIntervals);
    return ret;
  }

  public bool isGripMoving() {
    bool ret = AriaCSPINVOKE.ArGripper_isGripMoving(swigCPtr);
    return ret;
  }

  public bool isLiftMoving() {
    bool ret = AriaCSPINVOKE.ArGripper_isLiftMoving(swigCPtr);
    return ret;
  }

  public int getGripState() {
    int ret = AriaCSPINVOKE.ArGripper_getGripState(swigCPtr);
    return ret;
  }

  public int getPaddleState() {
    int ret = AriaCSPINVOKE.ArGripper_getPaddleState(swigCPtr);
    return ret;
  }

  public int getBreakBeamState() {
    int ret = AriaCSPINVOKE.ArGripper_getBreakBeamState(swigCPtr);
    return ret;
  }

  public bool isLiftMaxed() {
    bool ret = AriaCSPINVOKE.ArGripper_isLiftMaxed(swigCPtr);
    return ret;
  }

  public int getType() {
    int ret = AriaCSPINVOKE.ArGripper_getType(swigCPtr);
    return ret;
  }

  public void setType(int type) {
    AriaCSPINVOKE.ArGripper_setType(swigCPtr, type);
  }

  public int getMSecSinceLastPacket() {
    int ret = AriaCSPINVOKE.ArGripper_getMSecSinceLastPacket(swigCPtr);
    return ret;
  }

  public int getGraspTime() {
    int ret = AriaCSPINVOKE.ArGripper_getGraspTime(swigCPtr);
    return ret;
  }

  public void logState() {
    AriaCSPINVOKE.ArGripper_logState(swigCPtr);
  }

  public bool packetHandler(ArRobotPacket packet) {
    bool ret = AriaCSPINVOKE.ArGripper_packetHandler(swigCPtr, ArRobotPacket.getCPtr(packet));
    return ret;
  }

  public void connectHandler() {
    AriaCSPINVOKE.ArGripper_connectHandler(swigCPtr);
  }

  public enum Type {
    QUERYTYPE,
    GENIO,
    USERIO,
    GRIPPAC,
    NOGRIPPER
  }

}

}
