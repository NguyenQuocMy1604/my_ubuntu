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

public class ArConfigSection : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public ArConfigSection(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArConfigSection obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArConfigSection() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArConfigSection(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public ArConfigSection(string name, string comment, bool isQuiet, string categoryName) : this(AriaCSPINVOKE.new_ArConfigSection__SWIG_0(name, comment, isQuiet, categoryName), true) {
  }

  public ArConfigSection(string name, string comment, bool isQuiet) : this(AriaCSPINVOKE.new_ArConfigSection__SWIG_1(name, comment, isQuiet), true) {
  }

  public ArConfigSection(string name, string comment) : this(AriaCSPINVOKE.new_ArConfigSection__SWIG_2(name, comment), true) {
  }

  public ArConfigSection(string name) : this(AriaCSPINVOKE.new_ArConfigSection__SWIG_3(name), true) {
  }

  public ArConfigSection() : this(AriaCSPINVOKE.new_ArConfigSection__SWIG_4(), true) {
  }

  public ArConfigSection(ArConfigSection section) : this(AriaCSPINVOKE.new_ArConfigSection__SWIG_5(ArConfigSection.getCPtr(section)), true) {
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void copyAndDetach(ArConfigSection section) {
    AriaCSPINVOKE.ArConfigSection_copyAndDetach(swigCPtr, ArConfigSection.getCPtr(section));
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
  }

  public string getName() {
    string ret = AriaCSPINVOKE.ArConfigSection_getName(swigCPtr);
    return ret;
  }

  public string getComment() {
    string ret = AriaCSPINVOKE.ArConfigSection_getComment(swigCPtr);
    return ret;
  }

  public string getCategoryName() {
    string ret = AriaCSPINVOKE.ArConfigSection_getCategoryName(swigCPtr);
    return ret;
  }

  public string getFlags() {
    string ret = AriaCSPINVOKE.ArConfigSection_getFlags(swigCPtr);
    return ret;
  }

  public bool hasFlag(string flag) {
    bool ret = AriaCSPINVOKE.ArConfigSection_hasFlag(swigCPtr, flag);
    return ret;
  }

  public SWIGTYPE_p_std__listT_ArConfigArg_t getParams() {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArConfigSection_getParams(swigCPtr);
    SWIGTYPE_p_std__listT_ArConfigArg_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__listT_ArConfigArg_t(cPtr, false);
    return ret;
  }

  public void setName(string name) {
    AriaCSPINVOKE.ArConfigSection_setName(swigCPtr, name);
  }

  public void setComment(string comment) {
    AriaCSPINVOKE.ArConfigSection_setComment(swigCPtr, comment);
  }

  public bool addFlags(string flags, bool isQuiet) {
    bool ret = AriaCSPINVOKE.ArConfigSection_addFlags__SWIG_0(swigCPtr, flags, isQuiet);
    return ret;
  }

  public bool addFlags(string flags) {
    bool ret = AriaCSPINVOKE.ArConfigSection_addFlags__SWIG_1(swigCPtr, flags);
    return ret;
  }

  public bool remFlag(string dataFlag) {
    bool ret = AriaCSPINVOKE.ArConfigSection_remFlag(swigCPtr, dataFlag);
    return ret;
  }

  public ArConfigArg findParam(string paramName, bool isAllowStringHolders) {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArConfigSection_findParam__SWIG_0(swigCPtr, paramName, isAllowStringHolders);
    ArConfigArg ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArConfigArg(cPtr, false);
    return ret;
  }

  public ArConfigArg findParam(string paramName) {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArConfigSection_findParam__SWIG_1(swigCPtr, paramName);
    ArConfigArg ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArConfigArg(cPtr, false);
    return ret;
  }

  public ArConfigArg findParam(SWIGTYPE_p_std__listT_std__string_t paramNamePath, bool isAllowHolders) {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArConfigSection_findParam__SWIG_2(swigCPtr, SWIGTYPE_p_std__listT_std__string_t.getCPtr(paramNamePath), isAllowHolders);
    ArConfigArg ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArConfigArg(cPtr, false);
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ArConfigArg findParam(SWIGTYPE_p_std__listT_std__string_t paramNamePath) {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArConfigSection_findParam__SWIG_3(swigCPtr, SWIGTYPE_p_std__listT_std__string_t.getCPtr(paramNamePath));
    ArConfigArg ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArConfigArg(cPtr, false);
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ArConfigArg findParam(SWIGTYPE_p_p_char paramNamePath, int pathLength, bool isAllowHolders) {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArConfigSection_findParam__SWIG_4(swigCPtr, SWIGTYPE_p_p_char.getCPtr(paramNamePath), pathLength, isAllowHolders);
    ArConfigArg ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArConfigArg(cPtr, false);
    return ret;
  }

  public ArConfigArg findParam(SWIGTYPE_p_p_char paramNamePath, int pathLength) {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArConfigSection_findParam__SWIG_5(swigCPtr, SWIGTYPE_p_p_char.getCPtr(paramNamePath), pathLength);
    ArConfigArg ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArConfigArg(cPtr, false);
    return ret;
  }

  public bool containsParamsOfPriority(ArPriority.Priority highestPriority, ArPriority.Priority lowestPriority) {
    bool ret = AriaCSPINVOKE.ArConfigSection_containsParamsOfPriority(swigCPtr, (int)highestPriority, (int)lowestPriority);
    return ret;
  }

  public bool remStringHolder(string paramName) {
    bool ret = AriaCSPINVOKE.ArConfigSection_remStringHolder(swigCPtr, paramName);
    return ret;
  }

  public void setQuiet(bool isQuiet) {
    AriaCSPINVOKE.ArConfigSection_setQuiet(swigCPtr, isQuiet);
  }

}

}