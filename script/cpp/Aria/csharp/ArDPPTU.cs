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

public class ArDPPTU : ArPTZ {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  public ArDPPTU(global::System.IntPtr cPtr, bool cMemoryOwn) : base(AriaCSPINVOKE.ArDPPTU_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArDPPTU obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArDPPTU() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArDPPTU(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public ArDPPTU(ArRobot robot, ArDPPTU.DeviceType deviceType, int deviceIndex) : this(AriaCSPINVOKE.new_ArDPPTU__SWIG_0(ArRobot.getCPtr(robot), (int)deviceType, deviceIndex), true) {
  }

  public ArDPPTU(ArRobot robot, ArDPPTU.DeviceType deviceType) : this(AriaCSPINVOKE.new_ArDPPTU__SWIG_1(ArRobot.getCPtr(robot), (int)deviceType), true) {
  }

  public ArDPPTU(ArRobot robot) : this(AriaCSPINVOKE.new_ArDPPTU__SWIG_2(ArRobot.getCPtr(robot)), true) {
  }

  public override bool init() {
    bool ret = AriaCSPINVOKE.ArDPPTU_init(swigCPtr);
    return ret;
  }

  public override string getTypeName() {
    string ret = AriaCSPINVOKE.ArDPPTU_getTypeName(swigCPtr);
    return ret;
  }

  public override bool canZoom() {
    bool ret = AriaCSPINVOKE.ArDPPTU_canZoom(swigCPtr);
    return ret;
  }

  public override bool canGetRealPanTilt() {
    bool ret = AriaCSPINVOKE.ArDPPTU_canGetRealPanTilt(swigCPtr);
    return ret;
  }

  public bool blank() {
    bool ret = AriaCSPINVOKE.ArDPPTU_blank(swigCPtr);
    return ret;
  }

  public bool resetCalib() {
    bool ret = AriaCSPINVOKE.ArDPPTU_resetCalib(swigCPtr);
    return ret;
  }

  public bool disableReset() {
    bool ret = AriaCSPINVOKE.ArDPPTU_disableReset(swigCPtr);
    return ret;
  }

  public bool resetTilt() {
    bool ret = AriaCSPINVOKE.ArDPPTU_resetTilt(swigCPtr);
    return ret;
  }

  public bool resetPan() {
    bool ret = AriaCSPINVOKE.ArDPPTU_resetPan(swigCPtr);
    return ret;
  }

  public bool resetAll() {
    bool ret = AriaCSPINVOKE.ArDPPTU_resetAll(swigCPtr);
    return ret;
  }

  public bool enMon() {
    bool ret = AriaCSPINVOKE.ArDPPTU_enMon(swigCPtr);
    return ret;
  }

  public bool disMon() {
    bool ret = AriaCSPINVOKE.ArDPPTU_disMon(swigCPtr);
    return ret;
  }

  public bool saveSet() {
    bool ret = AriaCSPINVOKE.ArDPPTU_saveSet(swigCPtr);
    return ret;
  }

  public bool restoreSet() {
    bool ret = AriaCSPINVOKE.ArDPPTU_restoreSet(swigCPtr);
    return ret;
  }

  public bool factorySet() {
    bool ret = AriaCSPINVOKE.ArDPPTU_factorySet(swigCPtr);
    return ret;
  }

  public bool awaitExec() {
    bool ret = AriaCSPINVOKE.ArDPPTU_awaitExec(swigCPtr);
    return ret;
  }

  public bool haltAll() {
    bool ret = AriaCSPINVOKE.ArDPPTU_haltAll(swigCPtr);
    return ret;
  }

  public bool haltPan() {
    bool ret = AriaCSPINVOKE.ArDPPTU_haltPan(swigCPtr);
    return ret;
  }

  public bool haltTilt() {
    bool ret = AriaCSPINVOKE.ArDPPTU_haltTilt(swigCPtr);
    return ret;
  }

  public bool initMon(double deg1, double deg2, double deg3, double deg4) {
    bool ret = AriaCSPINVOKE.ArDPPTU_initMon(swigCPtr, deg1, deg2, deg3, deg4);
    return ret;
  }

  public bool limitEnforce(bool val) {
    bool ret = AriaCSPINVOKE.ArDPPTU_limitEnforce(swigCPtr, val);
    return ret;
  }

  public bool immedExec() {
    bool ret = AriaCSPINVOKE.ArDPPTU_immedExec(swigCPtr);
    return ret;
  }

  public bool slaveExec() {
    bool ret = AriaCSPINVOKE.ArDPPTU_slaveExec(swigCPtr);
    return ret;
  }

  public double getMaxPanSlew() {
    double ret = AriaCSPINVOKE.ArDPPTU_getMaxPanSlew(swigCPtr);
    return ret;
  }

  public override double getMaxPanSpeed() {
    double ret = AriaCSPINVOKE.ArDPPTU_getMaxPanSpeed(swigCPtr);
    return ret;
  }

  public double getMinPanSlew() {
    double ret = AriaCSPINVOKE.ArDPPTU_getMinPanSlew(swigCPtr);
    return ret;
  }

  public double getMaxTiltSlew() {
    double ret = AriaCSPINVOKE.ArDPPTU_getMaxTiltSlew(swigCPtr);
    return ret;
  }

  public override double getMaxTiltSpeed() {
    double ret = AriaCSPINVOKE.ArDPPTU_getMaxTiltSpeed(swigCPtr);
    return ret;
  }

  public double getMinTiltSlew() {
    double ret = AriaCSPINVOKE.ArDPPTU_getMinTiltSlew(swigCPtr);
    return ret;
  }

  public double getMaxPanAccel() {
    double ret = AriaCSPINVOKE.ArDPPTU_getMaxPanAccel(swigCPtr);
    return ret;
  }

  public double getMinPanAccel() {
    double ret = AriaCSPINVOKE.ArDPPTU_getMinPanAccel(swigCPtr);
    return ret;
  }

  public double getMaxTiltAccel() {
    double ret = AriaCSPINVOKE.ArDPPTU_getMaxTiltAccel(swigCPtr);
    return ret;
  }

  public double getMinTiltAccel() {
    double ret = AriaCSPINVOKE.ArDPPTU_getMinTiltAccel(swigCPtr);
    return ret;
  }

  public bool setMovePower(ArDPPTU.Axis axis, ArDPPTU.PowerMode mode) {
    bool ret = AriaCSPINVOKE.ArDPPTU_setMovePower(swigCPtr, (int)axis, (int)mode);
    return ret;
  }

  public bool setHoldPower(ArDPPTU.Axis axis, ArDPPTU.PowerMode mode) {
    bool ret = AriaCSPINVOKE.ArDPPTU_setHoldPower(swigCPtr, (int)axis, (int)mode);
    return ret;
  }

  public bool offStatPower() {
    bool ret = AriaCSPINVOKE.ArDPPTU_offStatPower(swigCPtr);
    return ret;
  }

  public bool regStatPower() {
    bool ret = AriaCSPINVOKE.ArDPPTU_regStatPower(swigCPtr);
    return ret;
  }

  public bool lowStatPower() {
    bool ret = AriaCSPINVOKE.ArDPPTU_lowStatPower(swigCPtr);
    return ret;
  }

  public bool highMotPower() {
    bool ret = AriaCSPINVOKE.ArDPPTU_highMotPower(swigCPtr);
    return ret;
  }

  public bool regMotPower() {
    bool ret = AriaCSPINVOKE.ArDPPTU_regMotPower(swigCPtr);
    return ret;
  }

  public bool lowMotPower() {
    bool ret = AriaCSPINVOKE.ArDPPTU_lowMotPower(swigCPtr);
    return ret;
  }

  public bool panAccel(double deg) {
    bool ret = AriaCSPINVOKE.ArDPPTU_panAccel(swigCPtr, deg);
    return ret;
  }

  public bool tiltAccel(double deg) {
    bool ret = AriaCSPINVOKE.ArDPPTU_tiltAccel(swigCPtr, deg);
    return ret;
  }

  public bool basePanSlew(double deg) {
    bool ret = AriaCSPINVOKE.ArDPPTU_basePanSlew(swigCPtr, deg);
    return ret;
  }

  public bool baseTiltSlew(double deg) {
    bool ret = AriaCSPINVOKE.ArDPPTU_baseTiltSlew(swigCPtr, deg);
    return ret;
  }

  public bool upperPanSlew(double deg) {
    bool ret = AriaCSPINVOKE.ArDPPTU_upperPanSlew(swigCPtr, deg);
    return ret;
  }

  public bool lowerPanSlew(double deg) {
    bool ret = AriaCSPINVOKE.ArDPPTU_lowerPanSlew(swigCPtr, deg);
    return ret;
  }

  public bool upperTiltSlew(double deg) {
    bool ret = AriaCSPINVOKE.ArDPPTU_upperTiltSlew(swigCPtr, deg);
    return ret;
  }

  public bool lowerTiltSlew(double deg) {
    bool ret = AriaCSPINVOKE.ArDPPTU_lowerTiltSlew(swigCPtr, deg);
    return ret;
  }

  public bool indepMove() {
    bool ret = AriaCSPINVOKE.ArDPPTU_indepMove(swigCPtr);
    return ret;
  }

  public bool velMove() {
    bool ret = AriaCSPINVOKE.ArDPPTU_velMove(swigCPtr);
    return ret;
  }

  public override bool panSlew(double deg) {
    bool ret = AriaCSPINVOKE.ArDPPTU_panSlew(swigCPtr, deg);
    return ret;
  }

  public override bool tiltSlew(double deg) {
    bool ret = AriaCSPINVOKE.ArDPPTU_tiltSlew(swigCPtr, deg);
    return ret;
  }

  public override bool canPanTiltSlew() {
    bool ret = AriaCSPINVOKE.ArDPPTU_canPanTiltSlew(swigCPtr);
    return ret;
  }

  public bool panSlewRel(double deg) {
    bool ret = AriaCSPINVOKE.ArDPPTU_panSlewRel(swigCPtr, deg);
    return ret;
  }

  public bool tiltSlewRel(double deg) {
    bool ret = AriaCSPINVOKE.ArDPPTU_tiltSlewRel(swigCPtr, deg);
    return ret;
  }

  public double getLastPanRequest() {
    double ret = AriaCSPINVOKE.ArDPPTU_getLastPanRequest(swigCPtr);
    return ret;
  }

  public double getLastTiltRequest() {
    double ret = AriaCSPINVOKE.ArDPPTU_getLastTiltRequest(swigCPtr);
    return ret;
  }

  public double getPanSlew() {
    double ret = AriaCSPINVOKE.ArDPPTU_getPanSlew(swigCPtr);
    return ret;
  }

  public double getTiltSlew() {
    double ret = AriaCSPINVOKE.ArDPPTU_getTiltSlew(swigCPtr);
    return ret;
  }

  public double getBasePanSlew() {
    double ret = AriaCSPINVOKE.ArDPPTU_getBasePanSlew(swigCPtr);
    return ret;
  }

  public double getBaseTiltSlew() {
    double ret = AriaCSPINVOKE.ArDPPTU_getBaseTiltSlew(swigCPtr);
    return ret;
  }

  public double getPanAccel() {
    double ret = AriaCSPINVOKE.ArDPPTU_getPanAccel(swigCPtr);
    return ret;
  }

  public double getTiltAccel() {
    double ret = AriaCSPINVOKE.ArDPPTU_getTiltAccel(swigCPtr);
    return ret;
  }

  public void query() {
    AriaCSPINVOKE.ArDPPTU_query(swigCPtr);
  }

  public enum DeviceType {
    PANTILT_DEFAULT,
    PANTILT_PTUD47,
    PANTILT_PTUD46
  }

  public enum Axis {
    PAN = 'P',
    TILT = 'T'
  }

  public enum PowerMode {
    OFF = 'O',
    LOW = 'L',
    NORMAL = 'R',
    HIGH = 'H'
  }

}

}