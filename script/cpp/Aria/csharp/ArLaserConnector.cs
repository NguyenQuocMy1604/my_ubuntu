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

public class ArLaserConnector : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public ArLaserConnector(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArLaserConnector obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArLaserConnector() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArLaserConnector(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public ArLaserConnector(ArArgumentParser parser, ArRobot robot, ArRobotConnector robotConnector, bool autoParseArgs, ArLog.LogLevel infoLogLevel, SWIGTYPE_p_ArRetFunctor1T_bool_char_const_p_t turnOnPowerOutputCB, SWIGTYPE_p_ArRetFunctor1T_bool_char_const_p_t turnOffPowerOutputCB) : this(AriaCSPINVOKE.new_ArLaserConnector__SWIG_0(ArArgumentParser.getCPtr(parser), ArRobot.getCPtr(robot), ArRobotConnector.getCPtr(robotConnector), autoParseArgs, (int)infoLogLevel, SWIGTYPE_p_ArRetFunctor1T_bool_char_const_p_t.getCPtr(turnOnPowerOutputCB), SWIGTYPE_p_ArRetFunctor1T_bool_char_const_p_t.getCPtr(turnOffPowerOutputCB)), true) {
  }

  public ArLaserConnector(ArArgumentParser parser, ArRobot robot, ArRobotConnector robotConnector, bool autoParseArgs, ArLog.LogLevel infoLogLevel, SWIGTYPE_p_ArRetFunctor1T_bool_char_const_p_t turnOnPowerOutputCB) : this(AriaCSPINVOKE.new_ArLaserConnector__SWIG_1(ArArgumentParser.getCPtr(parser), ArRobot.getCPtr(robot), ArRobotConnector.getCPtr(robotConnector), autoParseArgs, (int)infoLogLevel, SWIGTYPE_p_ArRetFunctor1T_bool_char_const_p_t.getCPtr(turnOnPowerOutputCB)), true) {
  }

  public ArLaserConnector(ArArgumentParser parser, ArRobot robot, ArRobotConnector robotConnector, bool autoParseArgs, ArLog.LogLevel infoLogLevel) : this(AriaCSPINVOKE.new_ArLaserConnector__SWIG_2(ArArgumentParser.getCPtr(parser), ArRobot.getCPtr(robot), ArRobotConnector.getCPtr(robotConnector), autoParseArgs, (int)infoLogLevel), true) {
  }

  public ArLaserConnector(ArArgumentParser parser, ArRobot robot, ArRobotConnector robotConnector, bool autoParseArgs) : this(AriaCSPINVOKE.new_ArLaserConnector__SWIG_3(ArArgumentParser.getCPtr(parser), ArRobot.getCPtr(robot), ArRobotConnector.getCPtr(robotConnector), autoParseArgs), true) {
  }

  public ArLaserConnector(ArArgumentParser parser, ArRobot robot, ArRobotConnector robotConnector) : this(AriaCSPINVOKE.new_ArLaserConnector__SWIG_4(ArArgumentParser.getCPtr(parser), ArRobot.getCPtr(robot), ArRobotConnector.getCPtr(robotConnector)), true) {
  }

  public bool connectLasers(bool continueOnFailedConnect, bool addConnectedLasersToRobot, bool addAllLasersToRobot, bool turnOnLasers, bool powerCycleLaserOnFailedConnect, SWIGTYPE_p_int failedOnLaser) {
    bool ret = AriaCSPINVOKE.ArLaserConnector_connectLasers__SWIG_0(swigCPtr, continueOnFailedConnect, addConnectedLasersToRobot, addAllLasersToRobot, turnOnLasers, powerCycleLaserOnFailedConnect, SWIGTYPE_p_int.getCPtr(failedOnLaser));
    return ret;
  }

  public bool connectLasers(bool continueOnFailedConnect, bool addConnectedLasersToRobot, bool addAllLasersToRobot, bool turnOnLasers, bool powerCycleLaserOnFailedConnect) {
    bool ret = AriaCSPINVOKE.ArLaserConnector_connectLasers__SWIG_1(swigCPtr, continueOnFailedConnect, addConnectedLasersToRobot, addAllLasersToRobot, turnOnLasers, powerCycleLaserOnFailedConnect);
    return ret;
  }

  public bool connectLasers(bool continueOnFailedConnect, bool addConnectedLasersToRobot, bool addAllLasersToRobot, bool turnOnLasers) {
    bool ret = AriaCSPINVOKE.ArLaserConnector_connectLasers__SWIG_2(swigCPtr, continueOnFailedConnect, addConnectedLasersToRobot, addAllLasersToRobot, turnOnLasers);
    return ret;
  }

  public bool connectLasers(bool continueOnFailedConnect, bool addConnectedLasersToRobot, bool addAllLasersToRobot) {
    bool ret = AriaCSPINVOKE.ArLaserConnector_connectLasers__SWIG_3(swigCPtr, continueOnFailedConnect, addConnectedLasersToRobot, addAllLasersToRobot);
    return ret;
  }

  public bool connectLasers(bool continueOnFailedConnect, bool addConnectedLasersToRobot) {
    bool ret = AriaCSPINVOKE.ArLaserConnector_connectLasers__SWIG_4(swigCPtr, continueOnFailedConnect, addConnectedLasersToRobot);
    return ret;
  }

  public bool connectLasers(bool continueOnFailedConnect) {
    bool ret = AriaCSPINVOKE.ArLaserConnector_connectLasers__SWIG_5(swigCPtr, continueOnFailedConnect);
    return ret;
  }

  public bool connectLasers() {
    bool ret = AriaCSPINVOKE.ArLaserConnector_connectLasers__SWIG_6(swigCPtr);
    return ret;
  }

  public bool setupLaser(ArLaser laser, int laserNumber) {
    bool ret = AriaCSPINVOKE.ArLaserConnector_setupLaser__SWIG_0(swigCPtr, ArLaser.getCPtr(laser), laserNumber);
    return ret;
  }

  public bool setupLaser(ArLaser laser) {
    bool ret = AriaCSPINVOKE.ArLaserConnector_setupLaser__SWIG_1(swigCPtr, ArLaser.getCPtr(laser));
    return ret;
  }

  public bool connectLaser(ArLaser laser, int laserNumber, bool forceConnection) {
    bool ret = AriaCSPINVOKE.ArLaserConnector_connectLaser__SWIG_0(swigCPtr, ArLaser.getCPtr(laser), laserNumber, forceConnection);
    return ret;
  }

  public bool connectLaser(ArLaser laser, int laserNumber) {
    bool ret = AriaCSPINVOKE.ArLaserConnector_connectLaser__SWIG_1(swigCPtr, ArLaser.getCPtr(laser), laserNumber);
    return ret;
  }

  public bool connectLaser(ArLaser laser) {
    bool ret = AriaCSPINVOKE.ArLaserConnector_connectLaser__SWIG_2(swigCPtr, ArLaser.getCPtr(laser));
    return ret;
  }

  public bool addLaser(ArLaser laser, int laserNumber) {
    bool ret = AriaCSPINVOKE.ArLaserConnector_addLaser__SWIG_0(swigCPtr, ArLaser.getCPtr(laser), laserNumber);
    return ret;
  }

  public bool addLaser(ArLaser laser) {
    bool ret = AriaCSPINVOKE.ArLaserConnector_addLaser__SWIG_1(swigCPtr, ArLaser.getCPtr(laser));
    return ret;
  }

  public bool addPlaceholderLaser(ArLaser placeholderLaser, int laserNumber, bool takeOwnershipOfPlaceholder) {
    bool ret = AriaCSPINVOKE.ArLaserConnector_addPlaceholderLaser__SWIG_0(swigCPtr, ArLaser.getCPtr(placeholderLaser), laserNumber, takeOwnershipOfPlaceholder);
    return ret;
  }

  public bool addPlaceholderLaser(ArLaser placeholderLaser, int laserNumber) {
    bool ret = AriaCSPINVOKE.ArLaserConnector_addPlaceholderLaser__SWIG_1(swigCPtr, ArLaser.getCPtr(placeholderLaser), laserNumber);
    return ret;
  }

  public bool addPlaceholderLaser(ArLaser placeholderLaser) {
    bool ret = AriaCSPINVOKE.ArLaserConnector_addPlaceholderLaser__SWIG_2(swigCPtr, ArLaser.getCPtr(placeholderLaser));
    return ret;
  }

  public bool parseArgs() {
    bool ret = AriaCSPINVOKE.ArLaserConnector_parseArgs__SWIG_0(swigCPtr);
    return ret;
  }

  public bool parseArgs(ArArgumentParser parser) {
    bool ret = AriaCSPINVOKE.ArLaserConnector_parseArgs__SWIG_1(swigCPtr, ArArgumentParser.getCPtr(parser));
    return ret;
  }

  public void logOptions() {
    AriaCSPINVOKE.ArLaserConnector_logOptions(swigCPtr);
  }

  public ArLaser getLaser(int laserNumber) {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArLaserConnector_getLaser(swigCPtr, laserNumber);
    ArLaser ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArLaser(cPtr, false);
    return ret;
  }

  public bool replaceLaser(ArLaser laser, int laserNumber) {
    bool ret = AriaCSPINVOKE.ArLaserConnector_replaceLaser(swigCPtr, ArLaser.getCPtr(laser), laserNumber);
    return ret;
  }

  public void logLaserData() {
    AriaCSPINVOKE.ArLaserConnector_logLaserData(swigCPtr);
  }

}

}
