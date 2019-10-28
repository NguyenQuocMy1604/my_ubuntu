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

public class ArMapInterface : ArHasFileName {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  public ArMapInterface(global::System.IntPtr cPtr, bool cMemoryOwn) : base(AriaCSPINVOKE.ArMapInterface_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArMapInterface obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArMapInterface() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArMapInterface(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static string MAP_CATEGORY_2D {
    set {
      AriaCSPINVOKE.ArMapInterface_MAP_CATEGORY_2D_set(value);
    } 
    get {
      string ret = AriaCSPINVOKE.ArMapInterface_MAP_CATEGORY_2D_get();
      return ret;
    } 
  }

  public static string MAP_CATEGORY_2D_MULTI_SOURCES {
    set {
      AriaCSPINVOKE.ArMapInterface_MAP_CATEGORY_2D_MULTI_SOURCES_set(value);
    } 
    get {
      string ret = AriaCSPINVOKE.ArMapInterface_MAP_CATEGORY_2D_MULTI_SOURCES_get();
      return ret;
    } 
  }

  public static string MAP_CATEGORY_2D_EXTENDED {
    set {
      AriaCSPINVOKE.ArMapInterface_MAP_CATEGORY_2D_EXTENDED_set(value);
    } 
    get {
      string ret = AriaCSPINVOKE.ArMapInterface_MAP_CATEGORY_2D_EXTENDED_get();
      return ret;
    } 
  }

  public static string MAP_CATEGORY_2D_COMPOSITE {
    set {
      AriaCSPINVOKE.ArMapInterface_MAP_CATEGORY_2D_COMPOSITE_set(value);
    } 
    get {
      string ret = AriaCSPINVOKE.ArMapInterface_MAP_CATEGORY_2D_COMPOSITE_get();
      return ret;
    } 
  }

  public static string MAP_CATEGORY_2D_TEMPLATE {
    set {
      AriaCSPINVOKE.ArMapInterface_MAP_CATEGORY_2D_TEMPLATE_set(value);
    } 
    get {
      string ret = AriaCSPINVOKE.ArMapInterface_MAP_CATEGORY_2D_TEMPLATE_get();
      return ret;
    } 
  }

  public static SWIGTYPE_p_std__listT_std__string_t getMapCategoryList() {
    SWIGTYPE_p_std__listT_std__string_t ret = new SWIGTYPE_p_std__listT_std__string_t(AriaCSPINVOKE.ArMapInterface_getMapCategoryList(), true);
    return ret;
  }

  public static string createRealFileName(string baseDirectory, string fileName, bool isIgnoreCase) {
    string ret = AriaCSPINVOKE.ArMapInterface_createRealFileName__SWIG_0(baseDirectory, fileName, isIgnoreCase);
    return ret;
  }

  public virtual void clear() {
    AriaCSPINVOKE.ArMapInterface_clear(swigCPtr);
  }

  public virtual bool set(ArMapInterface other) {
    bool ret = AriaCSPINVOKE.ArMapInterface_set(swigCPtr, ArMapInterface.getCPtr(other));
    return ret;
  }

  public virtual ArMapInterface clone() {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArMapInterface_clone(swigCPtr);
    ArMapInterface ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArMapInterface(cPtr, false);
    return ret;
  }

  public virtual SWIGTYPE_p_std__listT_std__string_t getScanTypes() {
    SWIGTYPE_p_std__listT_std__string_t ret = new SWIGTYPE_p_std__listT_std__string_t(AriaCSPINVOKE.ArMapInterface_getScanTypes(swigCPtr), true);
    return ret;
  }

  public virtual bool setScanTypes(SWIGTYPE_p_std__listT_std__string_t scanTypeList) {
    bool ret = AriaCSPINVOKE.ArMapInterface_setScanTypes(swigCPtr, SWIGTYPE_p_std__listT_std__string_t.getCPtr(scanTypeList));
    if (AriaCSPINVOKE.SWIGPendingException.Pending) throw AriaCSPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int lockObj() {
    int ret = AriaCSPINVOKE.ArMapInterface_lockObj(swigCPtr);
    return ret;
  }

  public virtual int tryLock() {
    int ret = AriaCSPINVOKE.ArMapInterface_tryLock(swigCPtr);
    return ret;
  }

  public virtual int unlockObj() {
    int ret = AriaCSPINVOKE.ArMapInterface_unlockObj(swigCPtr);
    return ret;
  }

  public virtual void mapChanged() {
    AriaCSPINVOKE.ArMapInterface_mapChanged__SWIG_0(swigCPtr);
  }

  public virtual void mapChanged(bool invokePathPlanningCB, bool invokeLocalizationCB) {
    AriaCSPINVOKE.ArMapInterface_mapChanged__SWIG_1(swigCPtr, invokePathPlanningCB, invokeLocalizationCB);
  }

  public virtual void addMapChangedCBPos(ArFunctor functor, ArListPos.Pos position) {
    AriaCSPINVOKE.ArMapInterface_addMapChangedCBPos(swigCPtr, ArFunctor.getCPtr(functor), (int)position);
  }

  public virtual void addMapChangedCB(ArFunctor functor, int position) {
    AriaCSPINVOKE.ArMapInterface_addMapChangedCB__SWIG_0(swigCPtr, ArFunctor.getCPtr(functor), position);
  }

  public virtual void addMapChangedCB(ArFunctor functor) {
    AriaCSPINVOKE.ArMapInterface_addMapChangedCB__SWIG_1(swigCPtr, ArFunctor.getCPtr(functor));
  }

  public virtual void remMapChangedCB(ArFunctor functor) {
    AriaCSPINVOKE.ArMapInterface_remMapChangedCB(swigCPtr, ArFunctor.getCPtr(functor));
  }

  public virtual void addMapChangedPathPlanningCB(ArFunctor functor, int position) {
    AriaCSPINVOKE.ArMapInterface_addMapChangedPathPlanningCB__SWIG_0(swigCPtr, ArFunctor.getCPtr(functor), position);
  }

  public virtual void addMapChangedPathPlanningCB(ArFunctor functor) {
    AriaCSPINVOKE.ArMapInterface_addMapChangedPathPlanningCB__SWIG_1(swigCPtr, ArFunctor.getCPtr(functor));
  }

  public virtual void remMapChangedPathPlanningCB(ArFunctor functor) {
    AriaCSPINVOKE.ArMapInterface_remMapChangedPathPlanningCB(swigCPtr, ArFunctor.getCPtr(functor));
  }

  public virtual void addMapChangedLocalizationCB(ArFunctor functor, int position) {
    AriaCSPINVOKE.ArMapInterface_addMapChangedLocalizationCB__SWIG_0(swigCPtr, ArFunctor.getCPtr(functor), position);
  }

  public virtual void addMapChangedLocalizationCB(ArFunctor functor) {
    AriaCSPINVOKE.ArMapInterface_addMapChangedLocalizationCB__SWIG_1(swigCPtr, ArFunctor.getCPtr(functor));
  }

  public virtual void remMapChangedLocalizationCB(ArFunctor functor) {
    AriaCSPINVOKE.ArMapInterface_remMapChangedLocalizationCB(swigCPtr, ArFunctor.getCPtr(functor));
  }

  public virtual void addPreMapChangedCBPos(ArFunctor functor, ArListPos.Pos position) {
    AriaCSPINVOKE.ArMapInterface_addPreMapChangedCBPos(swigCPtr, ArFunctor.getCPtr(functor), (int)position);
  }

  public virtual void addPreMapChangedCB(ArFunctor functor, int position) {
    AriaCSPINVOKE.ArMapInterface_addPreMapChangedCB__SWIG_0(swigCPtr, ArFunctor.getCPtr(functor), position);
  }

  public virtual void addPreMapChangedCB(ArFunctor functor) {
    AriaCSPINVOKE.ArMapInterface_addPreMapChangedCB__SWIG_1(swigCPtr, ArFunctor.getCPtr(functor));
  }

  public virtual void remPreMapChangedCB(ArFunctor functor) {
    AriaCSPINVOKE.ArMapInterface_remPreMapChangedCB(swigCPtr, ArFunctor.getCPtr(functor));
  }

  public virtual void addPreParseFileCB(SWIGTYPE_p_ArFunctor1T_std__string_t functor) {
    AriaCSPINVOKE.ArMapInterface_addPreParseFileCB(swigCPtr, SWIGTYPE_p_ArFunctor1T_std__string_t.getCPtr(functor));
  }

  public virtual void remPreParseFileCB(SWIGTYPE_p_ArFunctor1T_std__string_t functor) {
    AriaCSPINVOKE.ArMapInterface_remPreParseFileCB(swigCPtr, SWIGTYPE_p_ArFunctor1T_std__string_t.getCPtr(functor));
  }

  public virtual void setMapChangedLogLevel(ArLog.LogLevel level) {
    AriaCSPINVOKE.ArMapInterface_setMapChangedLogLevel(swigCPtr, (int)level);
  }

  public virtual ArLog.LogLevel getMapChangedLogLevel() {
    ArLog.LogLevel ret = (ArLog.LogLevel)AriaCSPINVOKE.ArMapInterface_getMapChangedLogLevel(swigCPtr);
    return ret;
  }

  public virtual void writeToFunctor(ArFunctor1_CString functor, string endOfLineChars) {
    AriaCSPINVOKE.ArMapInterface_writeToFunctor(swigCPtr, ArFunctor1_CString.getCPtr(functor), endOfLineChars);
  }

  public virtual void writeObjectsToFunctor(ArFunctor1_CString functor, string endOfLineChars, bool isOverrideAsSingleScan, string maxCategory) {
    AriaCSPINVOKE.ArMapInterface_writeObjectsToFunctor__SWIG_0(swigCPtr, ArFunctor1_CString.getCPtr(functor), endOfLineChars, isOverrideAsSingleScan, maxCategory);
  }

  public virtual void writeObjectsToFunctor(ArFunctor1_CString functor, string endOfLineChars, bool isOverrideAsSingleScan) {
    AriaCSPINVOKE.ArMapInterface_writeObjectsToFunctor__SWIG_1(swigCPtr, ArFunctor1_CString.getCPtr(functor), endOfLineChars, isOverrideAsSingleScan);
  }

  public virtual void writeObjectsToFunctor(ArFunctor1_CString functor, string endOfLineChars) {
    AriaCSPINVOKE.ArMapInterface_writeObjectsToFunctor__SWIG_2(swigCPtr, ArFunctor1_CString.getCPtr(functor), endOfLineChars);
  }

  public virtual void addPreWriteFileCB(ArFunctor functor, ArListPos.Pos position) {
    AriaCSPINVOKE.ArMapInterface_addPreWriteFileCB__SWIG_0(swigCPtr, ArFunctor.getCPtr(functor), (int)position);
  }

  public virtual void addPreWriteFileCB(ArFunctor functor) {
    AriaCSPINVOKE.ArMapInterface_addPreWriteFileCB__SWIG_1(swigCPtr, ArFunctor.getCPtr(functor));
  }

  public virtual void remPreWriteFileCB(ArFunctor functor) {
    AriaCSPINVOKE.ArMapInterface_remPreWriteFileCB(swigCPtr, ArFunctor.getCPtr(functor));
  }

  public virtual void addPostWriteFileCB(ArFunctor functor, ArListPos.Pos position) {
    AriaCSPINVOKE.ArMapInterface_addPostWriteFileCB__SWIG_0(swigCPtr, ArFunctor.getCPtr(functor), (int)position);
  }

  public virtual void addPostWriteFileCB(ArFunctor functor) {
    AriaCSPINVOKE.ArMapInterface_addPostWriteFileCB__SWIG_1(swigCPtr, ArFunctor.getCPtr(functor));
  }

  public virtual void remPostWriteFileCB(ArFunctor functor) {
    AriaCSPINVOKE.ArMapInterface_remPostWriteFileCB(swigCPtr, ArFunctor.getCPtr(functor));
  }

  public virtual bool getMapId(SWIGTYPE_p_ArMapId mapIdOut, bool isInternalCall) {
    bool ret = AriaCSPINVOKE.ArMapInterface_getMapId__SWIG_0(swigCPtr, SWIGTYPE_p_ArMapId.getCPtr(mapIdOut), isInternalCall);
    return ret;
  }

  public virtual bool getMapId(SWIGTYPE_p_ArMapId mapIdOut) {
    bool ret = AriaCSPINVOKE.ArMapInterface_getMapId__SWIG_1(swigCPtr, SWIGTYPE_p_ArMapId.getCPtr(mapIdOut));
    return ret;
  }

  public virtual bool calculateChecksum(SWIGTYPE_p_unsigned_char md5DigestBuffer, uint md5DigestBufferLen) {
    bool ret = AriaCSPINVOKE.ArMapInterface_calculateChecksum(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(md5DigestBuffer), md5DigestBufferLen);
    return ret;
  }

  public virtual string getBaseDirectory() {
    string ret = AriaCSPINVOKE.ArMapInterface_getBaseDirectory(swigCPtr);
    return ret;
  }

  public virtual void setBaseDirectory(string baseDirectory) {
    AriaCSPINVOKE.ArMapInterface_setBaseDirectory(swigCPtr, baseDirectory);
  }

  public virtual string getTempDirectory() {
    string ret = AriaCSPINVOKE.ArMapInterface_getTempDirectory(swigCPtr);
    return ret;
  }

  public virtual void setTempDirectory(string tempDirectory) {
    AriaCSPINVOKE.ArMapInterface_setTempDirectory(swigCPtr, tempDirectory);
  }

  public virtual string createRealFileName(string fileName) {
    string ret = AriaCSPINVOKE.ArMapInterface_createRealFileName__SWIG_1(swigCPtr, fileName);
    return ret;
  }

  public override string getFileName() {
    string ret = AriaCSPINVOKE.ArMapInterface_getFileName(swigCPtr);
    return ret;
  }

  public virtual void setSourceFileName(string sourceName, string fileName, bool isInternalCall) {
    AriaCSPINVOKE.ArMapInterface_setSourceFileName__SWIG_0(swigCPtr, sourceName, fileName, isInternalCall);
  }

  public virtual void setSourceFileName(string sourceName, string fileName) {
    AriaCSPINVOKE.ArMapInterface_setSourceFileName__SWIG_1(swigCPtr, sourceName, fileName);
  }

  public virtual bool refresh() {
    bool ret = AriaCSPINVOKE.ArMapInterface_refresh(swigCPtr);
    return ret;
  }

  public virtual void setIgnoreEmptyFileName(bool ignore) {
    AriaCSPINVOKE.ArMapInterface_setIgnoreEmptyFileName(swigCPtr, ignore);
  }

  public virtual bool getIgnoreEmptyFileName() {
    bool ret = AriaCSPINVOKE.ArMapInterface_getIgnoreEmptyFileName(swigCPtr);
    return ret;
  }

  public virtual void setIgnoreCase(bool ignoreCase) {
    AriaCSPINVOKE.ArMapInterface_setIgnoreCase__SWIG_0(swigCPtr, ignoreCase);
  }

  public virtual void setIgnoreCase() {
    AriaCSPINVOKE.ArMapInterface_setIgnoreCase__SWIG_1(swigCPtr);
  }

  public virtual bool getIgnoreCase() {
    bool ret = AriaCSPINVOKE.ArMapInterface_getIgnoreCase(swigCPtr);
    return ret;
  }

  public virtual ArMapInfoInterface getInactiveInfo() {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArMapInterface_getInactiveInfo(swigCPtr);
    ArMapInfoInterface ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArMapInfoInterface(cPtr, false);
    return ret;
  }

  public virtual ArMapObjectsInterface getInactiveObjects() {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArMapInterface_getInactiveObjects(swigCPtr);
    ArMapObjectsInterface ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArMapObjectsInterface(cPtr, false);
    return ret;
  }

  public virtual ArMapObjectsInterface getChildObjects() {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArMapInterface_getChildObjects(swigCPtr);
    ArMapObjectsInterface ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArMapObjectsInterface(cPtr, false);
    return ret;
  }

  public virtual ArArgumentBuilder findMapObjectParams(string mapObjectName) {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArMapInterface_findMapObjectParams(swigCPtr, mapObjectName);
    ArArgumentBuilder ret = (cPtr == global::System.IntPtr.Zero) ? null : new ArArgumentBuilder(cPtr, false);
    return ret;
  }

  public virtual bool setMapObjectParams(string mapObjectName, ArArgumentBuilder arg1, SWIGTYPE_p_ArMapChangeDetails changeDetails) {
    bool ret = AriaCSPINVOKE.ArMapInterface_setMapObjectParams__SWIG_0(swigCPtr, mapObjectName, ArArgumentBuilder.getCPtr(arg1), SWIGTYPE_p_ArMapChangeDetails.getCPtr(changeDetails));
    return ret;
  }

  public virtual bool setMapObjectParams(string mapObjectName, ArArgumentBuilder arg1) {
    bool ret = AriaCSPINVOKE.ArMapInterface_setMapObjectParams__SWIG_1(swigCPtr, mapObjectName, ArArgumentBuilder.getCPtr(arg1));
    return ret;
  }

  public virtual SWIGTYPE_p_std__listT_ArArgumentBuilder_p_t getRemainder() {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArMapInterface_getRemainder(swigCPtr);
    SWIGTYPE_p_std__listT_ArArgumentBuilder_p_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__listT_ArArgumentBuilder_p_t(cPtr, false);
    return ret;
  }

  public virtual void setQuiet(bool isQuiet) {
    AriaCSPINVOKE.ArMapInterface_setQuiet(swigCPtr, isQuiet);
  }

  public virtual bool parseLine(string line) {
    bool ret = AriaCSPINVOKE.ArMapInterface_parseLine(swigCPtr, line);
    return ret;
  }

  public virtual void parsingComplete() {
    AriaCSPINVOKE.ArMapInterface_parsingComplete(swigCPtr);
  }

  public virtual bool isLoadingDataStarted() {
    bool ret = AriaCSPINVOKE.ArMapInterface_isLoadingDataStarted(swigCPtr);
    return ret;
  }

  public virtual bool isLoadingLinesAndDataStarted() {
    bool ret = AriaCSPINVOKE.ArMapInterface_isLoadingLinesAndDataStarted(swigCPtr);
    return ret;
  }

  public virtual string getMapCategory() {
    string ret = AriaCSPINVOKE.ArMapInterface_getMapCategory(swigCPtr);
    return ret;
  }

  public static readonly int MAX_MAP_NAME_LENGTH = AriaCSPINVOKE.ArMapInterface_MAX_MAP_NAME_LENGTH_get();

}

}