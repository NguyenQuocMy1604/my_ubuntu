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

public class ArActionDesired : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public ArActionDesired(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArActionDesired obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArActionDesired() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArActionDesired(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static double NO_STRENGTH {
    get {
      double ret = AriaCSPINVOKE.ArActionDesired_NO_STRENGTH_get();
      return ret;
    } 
  }

  public static double MIN_STRENGTH {
    get {
      double ret = AriaCSPINVOKE.ArActionDesired_MIN_STRENGTH_get();
      return ret;
    } 
  }

  public static double MAX_STRENGTH {
    get {
      double ret = AriaCSPINVOKE.ArActionDesired_MAX_STRENGTH_get();
      return ret;
    } 
  }

  public ArActionDesired() : this(AriaCSPINVOKE.new_ArActionDesired(), true) {
  }

  public virtual void setVel(double vel, double strength) {
    AriaCSPINVOKE.ArActionDesired_setVel__SWIG_0(swigCPtr, vel, strength);
  }

  public virtual void setVel(double vel) {
    AriaCSPINVOKE.ArActionDesired_setVel__SWIG_1(swigCPtr, vel);
  }

  public virtual void setDeltaHeading(double deltaHeading, double strength) {
    AriaCSPINVOKE.ArActionDesired_setDeltaHeading__SWIG_0(swigCPtr, deltaHeading, strength);
  }

  public virtual void setDeltaHeading(double deltaHeading) {
    AriaCSPINVOKE.ArActionDesired_setDeltaHeading__SWIG_1(swigCPtr, deltaHeading);
  }

  public virtual void setHeading(double heading, double strength) {
    AriaCSPINVOKE.ArActionDesired_setHeading__SWIG_0(swigCPtr, heading, strength);
  }

  public virtual void setHeading(double heading) {
    AriaCSPINVOKE.ArActionDesired_setHeading__SWIG_1(swigCPtr, heading);
  }

  public virtual void setRotVel(double rotVel, double strength) {
    AriaCSPINVOKE.ArActionDesired_setRotVel__SWIG_0(swigCPtr, rotVel, strength);
  }

  public virtual void setRotVel(double rotVel) {
    AriaCSPINVOKE.ArActionDesired_setRotVel__SWIG_1(swigCPtr, rotVel);
  }

  public virtual void setMaxVel(double maxVel, double strength, bool useSlowest) {
    AriaCSPINVOKE.ArActionDesired_setMaxVel__SWIG_0(swigCPtr, maxVel, strength, useSlowest);
  }

  public virtual void setMaxVel(double maxVel, double strength) {
    AriaCSPINVOKE.ArActionDesired_setMaxVel__SWIG_1(swigCPtr, maxVel, strength);
  }

  public virtual void setMaxVel(double maxVel) {
    AriaCSPINVOKE.ArActionDesired_setMaxVel__SWIG_2(swigCPtr, maxVel);
  }

  public virtual void setMaxNegVel(double maxVel, double strength, bool useSlowest) {
    AriaCSPINVOKE.ArActionDesired_setMaxNegVel__SWIG_0(swigCPtr, maxVel, strength, useSlowest);
  }

  public virtual void setMaxNegVel(double maxVel, double strength) {
    AriaCSPINVOKE.ArActionDesired_setMaxNegVel__SWIG_1(swigCPtr, maxVel, strength);
  }

  public virtual void setMaxNegVel(double maxVel) {
    AriaCSPINVOKE.ArActionDesired_setMaxNegVel__SWIG_2(swigCPtr, maxVel);
  }

  public virtual void setTransAccel(double transAccel, double strength, bool useSlowest) {
    AriaCSPINVOKE.ArActionDesired_setTransAccel__SWIG_0(swigCPtr, transAccel, strength, useSlowest);
  }

  public virtual void setTransAccel(double transAccel, double strength) {
    AriaCSPINVOKE.ArActionDesired_setTransAccel__SWIG_1(swigCPtr, transAccel, strength);
  }

  public virtual void setTransAccel(double transAccel) {
    AriaCSPINVOKE.ArActionDesired_setTransAccel__SWIG_2(swigCPtr, transAccel);
  }

  public virtual void setTransDecel(double transDecel, double strength, bool useFastestDecel) {
    AriaCSPINVOKE.ArActionDesired_setTransDecel__SWIG_0(swigCPtr, transDecel, strength, useFastestDecel);
  }

  public virtual void setTransDecel(double transDecel, double strength) {
    AriaCSPINVOKE.ArActionDesired_setTransDecel__SWIG_1(swigCPtr, transDecel, strength);
  }

  public virtual void setTransDecel(double transDecel) {
    AriaCSPINVOKE.ArActionDesired_setTransDecel__SWIG_2(swigCPtr, transDecel);
  }

  public virtual void setMaxRotVel(double maxVel, double strength, bool useSlowest) {
    AriaCSPINVOKE.ArActionDesired_setMaxRotVel__SWIG_0(swigCPtr, maxVel, strength, useSlowest);
  }

  public virtual void setMaxRotVel(double maxVel, double strength) {
    AriaCSPINVOKE.ArActionDesired_setMaxRotVel__SWIG_1(swigCPtr, maxVel, strength);
  }

  public virtual void setMaxRotVel(double maxVel) {
    AriaCSPINVOKE.ArActionDesired_setMaxRotVel__SWIG_2(swigCPtr, maxVel);
  }

  public virtual void setMaxRotVelPos(double maxVel, double strength, bool useSlowest) {
    AriaCSPINVOKE.ArActionDesired_setMaxRotVelPos__SWIG_0(swigCPtr, maxVel, strength, useSlowest);
  }

  public virtual void setMaxRotVelPos(double maxVel, double strength) {
    AriaCSPINVOKE.ArActionDesired_setMaxRotVelPos__SWIG_1(swigCPtr, maxVel, strength);
  }

  public virtual void setMaxRotVelPos(double maxVel) {
    AriaCSPINVOKE.ArActionDesired_setMaxRotVelPos__SWIG_2(swigCPtr, maxVel);
  }

  public virtual void setMaxRotVelNeg(double maxVel, double strength, bool useSlowest) {
    AriaCSPINVOKE.ArActionDesired_setMaxRotVelNeg__SWIG_0(swigCPtr, maxVel, strength, useSlowest);
  }

  public virtual void setMaxRotVelNeg(double maxVel, double strength) {
    AriaCSPINVOKE.ArActionDesired_setMaxRotVelNeg__SWIG_1(swigCPtr, maxVel, strength);
  }

  public virtual void setMaxRotVelNeg(double maxVel) {
    AriaCSPINVOKE.ArActionDesired_setMaxRotVelNeg__SWIG_2(swigCPtr, maxVel);
  }

  public virtual void setRotAccel(double rotAccel, double strength, bool useSlowest) {
    AriaCSPINVOKE.ArActionDesired_setRotAccel__SWIG_0(swigCPtr, rotAccel, strength, useSlowest);
  }

  public virtual void setRotAccel(double rotAccel, double strength) {
    AriaCSPINVOKE.ArActionDesired_setRotAccel__SWIG_1(swigCPtr, rotAccel, strength);
  }

  public virtual void setRotAccel(double rotAccel) {
    AriaCSPINVOKE.ArActionDesired_setRotAccel__SWIG_2(swigCPtr, rotAccel);
  }

  public virtual void setRotDecel(double rotDecel, double strength, bool useFastest) {
    AriaCSPINVOKE.ArActionDesired_setRotDecel__SWIG_0(swigCPtr, rotDecel, strength, useFastest);
  }

  public virtual void setRotDecel(double rotDecel, double strength) {
    AriaCSPINVOKE.ArActionDesired_setRotDecel__SWIG_1(swigCPtr, rotDecel, strength);
  }

  public virtual void setRotDecel(double rotDecel) {
    AriaCSPINVOKE.ArActionDesired_setRotDecel__SWIG_2(swigCPtr, rotDecel);
  }

  public virtual void setLeftLatVel(double latVel, double strength) {
    AriaCSPINVOKE.ArActionDesired_setLeftLatVel__SWIG_0(swigCPtr, latVel, strength);
  }

  public virtual void setLeftLatVel(double latVel) {
    AriaCSPINVOKE.ArActionDesired_setLeftLatVel__SWIG_1(swigCPtr, latVel);
  }

  public virtual void setRightLatVel(double latVel, double strength) {
    AriaCSPINVOKE.ArActionDesired_setRightLatVel__SWIG_0(swigCPtr, latVel, strength);
  }

  public virtual void setRightLatVel(double latVel) {
    AriaCSPINVOKE.ArActionDesired_setRightLatVel__SWIG_1(swigCPtr, latVel);
  }

  public virtual void setMaxLeftLatVel(double maxVel, double strength, bool useSlowest) {
    AriaCSPINVOKE.ArActionDesired_setMaxLeftLatVel__SWIG_0(swigCPtr, maxVel, strength, useSlowest);
  }

  public virtual void setMaxLeftLatVel(double maxVel, double strength) {
    AriaCSPINVOKE.ArActionDesired_setMaxLeftLatVel__SWIG_1(swigCPtr, maxVel, strength);
  }

  public virtual void setMaxLeftLatVel(double maxVel) {
    AriaCSPINVOKE.ArActionDesired_setMaxLeftLatVel__SWIG_2(swigCPtr, maxVel);
  }

  public virtual void setMaxRightLatVel(double maxVel, double strength, bool useSlowest) {
    AriaCSPINVOKE.ArActionDesired_setMaxRightLatVel__SWIG_0(swigCPtr, maxVel, strength, useSlowest);
  }

  public virtual void setMaxRightLatVel(double maxVel, double strength) {
    AriaCSPINVOKE.ArActionDesired_setMaxRightLatVel__SWIG_1(swigCPtr, maxVel, strength);
  }

  public virtual void setMaxRightLatVel(double maxVel) {
    AriaCSPINVOKE.ArActionDesired_setMaxRightLatVel__SWIG_2(swigCPtr, maxVel);
  }

  public virtual void setLatAccel(double latAccel, double strength, bool useSlowest) {
    AriaCSPINVOKE.ArActionDesired_setLatAccel__SWIG_0(swigCPtr, latAccel, strength, useSlowest);
  }

  public virtual void setLatAccel(double latAccel, double strength) {
    AriaCSPINVOKE.ArActionDesired_setLatAccel__SWIG_1(swigCPtr, latAccel, strength);
  }

  public virtual void setLatAccel(double latAccel) {
    AriaCSPINVOKE.ArActionDesired_setLatAccel__SWIG_2(swigCPtr, latAccel);
  }

  public virtual void setLatDecel(double latDecel, double strength, bool useFastest) {
    AriaCSPINVOKE.ArActionDesired_setLatDecel__SWIG_0(swigCPtr, latDecel, strength, useFastest);
  }

  public virtual void setLatDecel(double latDecel, double strength) {
    AriaCSPINVOKE.ArActionDesired_setLatDecel__SWIG_1(swigCPtr, latDecel, strength);
  }

  public virtual void setLatDecel(double latDecel) {
    AriaCSPINVOKE.ArActionDesired_setLatDecel__SWIG_2(swigCPtr, latDecel);
  }

  public virtual void reset() {
    AriaCSPINVOKE.ArActionDesired_reset(swigCPtr);
  }

  public virtual double getVel() {
    double ret = AriaCSPINVOKE.ArActionDesired_getVel(swigCPtr);
    return ret;
  }

  public virtual double getVelStrength() {
    double ret = AriaCSPINVOKE.ArActionDesired_getVelStrength(swigCPtr);
    return ret;
  }

  public virtual double getHeading() {
    double ret = AriaCSPINVOKE.ArActionDesired_getHeading(swigCPtr);
    return ret;
  }

  public virtual double getHeadingStrength() {
    double ret = AriaCSPINVOKE.ArActionDesired_getHeadingStrength(swigCPtr);
    return ret;
  }

  public virtual double getDeltaHeading() {
    double ret = AriaCSPINVOKE.ArActionDesired_getDeltaHeading(swigCPtr);
    return ret;
  }

  public virtual double getDeltaHeadingStrength() {
    double ret = AriaCSPINVOKE.ArActionDesired_getDeltaHeadingStrength(swigCPtr);
    return ret;
  }

  public virtual double getRotVel() {
    double ret = AriaCSPINVOKE.ArActionDesired_getRotVel(swigCPtr);
    return ret;
  }

  public virtual double getRotVelStrength() {
    double ret = AriaCSPINVOKE.ArActionDesired_getRotVelStrength(swigCPtr);
    return ret;
  }

  public virtual double getMaxVel() {
    double ret = AriaCSPINVOKE.ArActionDesired_getMaxVel(swigCPtr);
    return ret;
  }

  public virtual double getMaxVelStrength() {
    double ret = AriaCSPINVOKE.ArActionDesired_getMaxVelStrength(swigCPtr);
    return ret;
  }

  public virtual double getMaxVelSlowestUsed() {
    double ret = AriaCSPINVOKE.ArActionDesired_getMaxVelSlowestUsed(swigCPtr);
    return ret;
  }

  public virtual double getMaxNegVel() {
    double ret = AriaCSPINVOKE.ArActionDesired_getMaxNegVel(swigCPtr);
    return ret;
  }

  public virtual double getMaxNegVelStrength() {
    double ret = AriaCSPINVOKE.ArActionDesired_getMaxNegVelStrength(swigCPtr);
    return ret;
  }

  public virtual double getMaxNegVelSlowestUsed() {
    double ret = AriaCSPINVOKE.ArActionDesired_getMaxNegVelSlowestUsed(swigCPtr);
    return ret;
  }

  public virtual double getTransAccel() {
    double ret = AriaCSPINVOKE.ArActionDesired_getTransAccel(swigCPtr);
    return ret;
  }

  public virtual double getTransAccelStrength() {
    double ret = AriaCSPINVOKE.ArActionDesired_getTransAccelStrength(swigCPtr);
    return ret;
  }

  public virtual double getTransAccelSlowestUsed() {
    double ret = AriaCSPINVOKE.ArActionDesired_getTransAccelSlowestUsed(swigCPtr);
    return ret;
  }

  public virtual double getTransDecel() {
    double ret = AriaCSPINVOKE.ArActionDesired_getTransDecel(swigCPtr);
    return ret;
  }

  public virtual double getTransDecelStrength() {
    double ret = AriaCSPINVOKE.ArActionDesired_getTransDecelStrength(swigCPtr);
    return ret;
  }

  public virtual double getTransDecelFastestUsed() {
    double ret = AriaCSPINVOKE.ArActionDesired_getTransDecelFastestUsed(swigCPtr);
    return ret;
  }

  public virtual double getMaxRotVel() {
    double ret = AriaCSPINVOKE.ArActionDesired_getMaxRotVel(swigCPtr);
    return ret;
  }

  public virtual double getMaxRotVelStrength() {
    double ret = AriaCSPINVOKE.ArActionDesired_getMaxRotVelStrength(swigCPtr);
    return ret;
  }

  public virtual double getMaxRotVelSlowestUsed() {
    double ret = AriaCSPINVOKE.ArActionDesired_getMaxRotVelSlowestUsed(swigCPtr);
    return ret;
  }

  public virtual double getMaxRotVelPos() {
    double ret = AriaCSPINVOKE.ArActionDesired_getMaxRotVelPos(swigCPtr);
    return ret;
  }

  public virtual double getMaxRotVelPosStrength() {
    double ret = AriaCSPINVOKE.ArActionDesired_getMaxRotVelPosStrength(swigCPtr);
    return ret;
  }

  public virtual double getMaxRotVelPosSlowestUsed() {
    double ret = AriaCSPINVOKE.ArActionDesired_getMaxRotVelPosSlowestUsed(swigCPtr);
    return ret;
  }

  public virtual double getMaxRotVelNeg() {
    double ret = AriaCSPINVOKE.ArActionDesired_getMaxRotVelNeg(swigCPtr);
    return ret;
  }

  public virtual double getMaxRotVelNegStrength() {
    double ret = AriaCSPINVOKE.ArActionDesired_getMaxRotVelNegStrength(swigCPtr);
    return ret;
  }

  public virtual double getMaxRotVelNegSlowestUsed() {
    double ret = AriaCSPINVOKE.ArActionDesired_getMaxRotVelNegSlowestUsed(swigCPtr);
    return ret;
  }

  public virtual double getRotAccel() {
    double ret = AriaCSPINVOKE.ArActionDesired_getRotAccel(swigCPtr);
    return ret;
  }

  public virtual double getRotAccelStrength() {
    double ret = AriaCSPINVOKE.ArActionDesired_getRotAccelStrength(swigCPtr);
    return ret;
  }

  public virtual double getRotAccelSlowestUsed() {
    double ret = AriaCSPINVOKE.ArActionDesired_getRotAccelSlowestUsed(swigCPtr);
    return ret;
  }

  public virtual double getRotDecel() {
    double ret = AriaCSPINVOKE.ArActionDesired_getRotDecel(swigCPtr);
    return ret;
  }

  public virtual double getRotDecelStrength() {
    double ret = AriaCSPINVOKE.ArActionDesired_getRotDecelStrength(swigCPtr);
    return ret;
  }

  public virtual double getRotDecelFastestUsed() {
    double ret = AriaCSPINVOKE.ArActionDesired_getRotDecelFastestUsed(swigCPtr);
    return ret;
  }

  public virtual double getLatVel() {
    double ret = AriaCSPINVOKE.ArActionDesired_getLatVel(swigCPtr);
    return ret;
  }

  public virtual double getLatVelStrength() {
    double ret = AriaCSPINVOKE.ArActionDesired_getLatVelStrength(swigCPtr);
    return ret;
  }

  public virtual double getMaxLeftLatVel() {
    double ret = AriaCSPINVOKE.ArActionDesired_getMaxLeftLatVel(swigCPtr);
    return ret;
  }

  public virtual double getMaxLeftLatVelStrength() {
    double ret = AriaCSPINVOKE.ArActionDesired_getMaxLeftLatVelStrength(swigCPtr);
    return ret;
  }

  public virtual double getMaxLeftLatVelSlowestUsed() {
    double ret = AriaCSPINVOKE.ArActionDesired_getMaxLeftLatVelSlowestUsed(swigCPtr);
    return ret;
  }

  public virtual double getMaxRightLatVel() {
    double ret = AriaCSPINVOKE.ArActionDesired_getMaxRightLatVel(swigCPtr);
    return ret;
  }

  public virtual double getMaxRightLatVelStrength() {
    double ret = AriaCSPINVOKE.ArActionDesired_getMaxRightLatVelStrength(swigCPtr);
    return ret;
  }

  public virtual double getMaxRightLatVelSlowestUsed() {
    double ret = AriaCSPINVOKE.ArActionDesired_getMaxRightLatVelSlowestUsed(swigCPtr);
    return ret;
  }

  public virtual double getLatAccel() {
    double ret = AriaCSPINVOKE.ArActionDesired_getLatAccel(swigCPtr);
    return ret;
  }

  public virtual double getLatAccelStrength() {
    double ret = AriaCSPINVOKE.ArActionDesired_getLatAccelStrength(swigCPtr);
    return ret;
  }

  public virtual double getLatAccelSlowestUsed() {
    double ret = AriaCSPINVOKE.ArActionDesired_getLatAccelSlowestUsed(swigCPtr);
    return ret;
  }

  public virtual double getLatDecel() {
    double ret = AriaCSPINVOKE.ArActionDesired_getLatDecel(swigCPtr);
    return ret;
  }

  public virtual double getLatDecelStrength() {
    double ret = AriaCSPINVOKE.ArActionDesired_getLatDecelStrength(swigCPtr);
    return ret;
  }

  public virtual double getLatDecelFastestUsed() {
    double ret = AriaCSPINVOKE.ArActionDesired_getLatDecelFastestUsed(swigCPtr);
    return ret;
  }

  public virtual void merge(ArActionDesired actDesired) {
    AriaCSPINVOKE.ArActionDesired_merge(swigCPtr, ArActionDesired.getCPtr(actDesired));
  }

  public virtual void startAverage() {
    AriaCSPINVOKE.ArActionDesired_startAverage(swigCPtr);
  }

  public virtual void addAverage(ArActionDesired actDesired) {
    AriaCSPINVOKE.ArActionDesired_addAverage(swigCPtr, ArActionDesired.getCPtr(actDesired));
  }

  public virtual void endAverage() {
    AriaCSPINVOKE.ArActionDesired_endAverage(swigCPtr);
  }

  public virtual void accountForRobotHeading(double robotHeading) {
    AriaCSPINVOKE.ArActionDesired_accountForRobotHeading(swigCPtr, robotHeading);
  }

  public virtual void log() {
    AriaCSPINVOKE.ArActionDesired_log(swigCPtr);
  }

  public virtual bool isAnythingDesired() {
    bool ret = AriaCSPINVOKE.ArActionDesired_isAnythingDesired(swigCPtr);
    return ret;
  }

  public virtual void sanityCheck(string actionName) {
    AriaCSPINVOKE.ArActionDesired_sanityCheck(swigCPtr, actionName);
  }

}

}