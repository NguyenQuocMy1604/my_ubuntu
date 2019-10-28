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

public class ArLaserReflectorDevice : ArRangeDevice {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  public ArLaserReflectorDevice(global::System.IntPtr cPtr, bool cMemoryOwn) : base(AriaCSPINVOKE.ArLaserReflectorDevice_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArLaserReflectorDevice obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArLaserReflectorDevice() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArLaserReflectorDevice(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public ArLaserReflectorDevice(ArRangeDevice laser, ArRobot robot, string name) : this(AriaCSPINVOKE.new_ArLaserReflectorDevice__SWIG_0(ArRangeDevice.getCPtr(laser), ArRobot.getCPtr(robot), name), true) {
  }

  public ArLaserReflectorDevice(ArRangeDevice laser, ArRobot robot) : this(AriaCSPINVOKE.new_ArLaserReflectorDevice__SWIG_1(ArRangeDevice.getCPtr(laser), ArRobot.getCPtr(robot)), true) {
  }

  public void processReadings() {
    AriaCSPINVOKE.ArLaserReflectorDevice_processReadings(swigCPtr);
  }

  public override void setRobot(ArRobot robot) {
    AriaCSPINVOKE.ArLaserReflectorDevice_setRobot(swigCPtr, ArRobot.getCPtr(robot));
  }

  public void addToConfig(ArConfig config, string section) {
    AriaCSPINVOKE.ArLaserReflectorDevice_addToConfig(swigCPtr, ArConfig.getCPtr(config), section);
  }

}

}
