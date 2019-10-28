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

public class ArMath : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public ArMath(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArMath obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArMath() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArMath(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static double epsilon() {
    double ret = AriaCSPINVOKE.ArMath_epsilon();
    return ret;
  }

  public static double addAngle(double ang1, double ang2) {
    double ret = AriaCSPINVOKE.ArMath_addAngle(ang1, ang2);
    return ret;
  }

  public static double subAngle(double ang1, double ang2) {
    double ret = AriaCSPINVOKE.ArMath_subAngle(ang1, ang2);
    return ret;
  }

  public static double fixAngle(double angle) {
    double ret = AriaCSPINVOKE.ArMath_fixAngle(angle);
    return ret;
  }

  public static double degToRad(double deg) {
    double ret = AriaCSPINVOKE.ArMath_degToRad(deg);
    return ret;
  }

  public static double radToDeg(double rad) {
    double ret = AriaCSPINVOKE.ArMath_radToDeg(rad);
    return ret;
  }

  public static double cos(double angle) {
    double ret = AriaCSPINVOKE.ArMath_cos(angle);
    return ret;
  }

  public static double sin(double angle) {
    double ret = AriaCSPINVOKE.ArMath_sin(angle);
    return ret;
  }

  public static double tan(double angle) {
    double ret = AriaCSPINVOKE.ArMath_tan(angle);
    return ret;
  }

  public static double atan2(double y, double x) {
    double ret = AriaCSPINVOKE.ArMath_atan2(y, x);
    return ret;
  }

  public static bool angleBetween(double angle, double startAngle, double endAngle) {
    bool ret = AriaCSPINVOKE.ArMath_angleBetween(angle, startAngle, endAngle);
    return ret;
  }

  public static double fabs(double val) {
    double ret = AriaCSPINVOKE.ArMath_fabs(val);
    return ret;
  }

  public static int roundInt(double val) {
    int ret = AriaCSPINVOKE.ArMath_roundInt(val);
    return ret;
  }

  public static short roundShort(double val) {
    short ret = AriaCSPINVOKE.ArMath_roundShort(val);
    return ret;
  }

  public static void pointRotate(out double x, out double y, double th) {
    AriaCSPINVOKE.ArMath_pointRotate(out x, out y, th);
  }

  public static int random() {
    int ret = AriaCSPINVOKE.ArMath_random();
    return ret;
  }

  public static int getRandMax() {
    int ret = AriaCSPINVOKE.ArMath_getRandMax();
    return ret;
  }

  public static int randomInRange(int m, int n) {
    int ret = AriaCSPINVOKE.ArMath_randomInRange(m, n);
    return ret;
  }

  public static double distanceBetween(double x1, double y1, double x2, double y2) {
    double ret = AriaCSPINVOKE.ArMath_distanceBetween(x1, y1, x2, y2);
    return ret;
  }

  public static double squaredDistanceBetween(double x1, double y1, double x2, double y2) {
    double ret = AriaCSPINVOKE.ArMath_squaredDistanceBetween(x1, y1, x2, y2);
    return ret;
  }

  public static double log2(double x) {
    double ret = AriaCSPINVOKE.ArMath_log2(x);
    return ret;
  }

  public static bool isNan(double d) {
    bool ret = AriaCSPINVOKE.ArMath_isNan__SWIG_0(d);
    return ret;
  }

  public static bool isNan(float f) {
    bool ret = AriaCSPINVOKE.ArMath_isNan__SWIG_1(f);
    return ret;
  }

  public static bool isFinite(float f) {
    bool ret = AriaCSPINVOKE.ArMath_isFinite__SWIG_0(f);
    return ret;
  }

  public static bool isFinite(double d) {
    bool ret = AriaCSPINVOKE.ArMath_isFinite__SWIG_1(d);
    return ret;
  }

  public static bool compareFloats(double f1, double f2, double epsilon) {
    bool ret = AriaCSPINVOKE.ArMath_compareFloats__SWIG_0(f1, f2, epsilon);
    return ret;
  }

  public static bool compareFloats(double f1, double f2) {
    bool ret = AriaCSPINVOKE.ArMath_compareFloats__SWIG_1(f1, f2);
    return ret;
  }

  public ArMath() : this(AriaCSPINVOKE.new_ArMath(), true) {
  }

}

}
