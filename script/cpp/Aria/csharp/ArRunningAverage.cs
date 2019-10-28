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

public class ArRunningAverage : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public ArRunningAverage(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArRunningAverage obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArRunningAverage() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArRunningAverage(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public ArRunningAverage(uint numToAverage) : this(AriaCSPINVOKE.new_ArRunningAverage(numToAverage), true) {
  }

  public double getAverage() {
    double ret = AriaCSPINVOKE.ArRunningAverage_getAverage(swigCPtr);
    return ret;
  }

  public void add(double val) {
    AriaCSPINVOKE.ArRunningAverage_add(swigCPtr, val);
  }

  public void clear() {
    AriaCSPINVOKE.ArRunningAverage_clear(swigCPtr);
  }

  public uint getNumToAverage() {
    uint ret = AriaCSPINVOKE.ArRunningAverage_getNumToAverage(swigCPtr);
    return ret;
  }

  public void setNumToAverage(uint numToAverage) {
    AriaCSPINVOKE.ArRunningAverage_setNumToAverage(swigCPtr, numToAverage);
  }

  public void setUseRootMeanSquare(bool useRootMeanSquare) {
    AriaCSPINVOKE.ArRunningAverage_setUseRootMeanSquare(swigCPtr, useRootMeanSquare);
  }

  public bool getUseRootMeanSquare() {
    bool ret = AriaCSPINVOKE.ArRunningAverage_getUseRootMeanSquare(swigCPtr);
    return ret;
  }

  public uint getCurrentNumAveraged() {
    uint ret = AriaCSPINVOKE.ArRunningAverage_getCurrentNumAveraged(swigCPtr);
    return ret;
  }

}

}