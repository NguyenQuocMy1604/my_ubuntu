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

public class ArRetFunctor_VoidP : ArFunctor {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  public ArRetFunctor_VoidP(global::System.IntPtr cPtr, bool cMemoryOwn) : base(AriaCSPINVOKE.ArRetFunctor_VoidP_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArRetFunctor_VoidP obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArRetFunctor_VoidP() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArRetFunctor_VoidP(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public override void invoke() {
    if (SwigDerivedClassHasMethod("invoke", swigMethodTypes0)) AriaCSPINVOKE.ArRetFunctor_VoidP_invokeSwigExplicitArRetFunctor_VoidP(swigCPtr); else AriaCSPINVOKE.ArRetFunctor_VoidP_invoke(swigCPtr);
  }

  public virtual SWIGTYPE_p_void invokeR() {
    global::System.IntPtr cPtr = AriaCSPINVOKE.ArRetFunctor_VoidP_invokeR(swigCPtr);
    SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public ArRetFunctor_VoidP() : this(AriaCSPINVOKE.new_ArRetFunctor_VoidP(), true) {
    SwigDirectorConnect();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("invoke", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateArRetFunctor_VoidP_0(SwigDirectorinvoke);
    if (SwigDerivedClassHasMethod("getName", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateArRetFunctor_VoidP_1(SwigDirectorgetName);
    if (SwigDerivedClassHasMethod("setName", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateArRetFunctor_VoidP_2(SwigDirectorsetName);
    if (SwigDerivedClassHasMethod("invokeR", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateArRetFunctor_VoidP_3(SwigDirectorinvokeR);
    AriaCSPINVOKE.ArRetFunctor_VoidP_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(ArRetFunctor_VoidP));
    return hasDerivedMethod;
  }

  private void SwigDirectorinvoke() {
    invoke();
  }

  private string SwigDirectorgetName() {
    return getName();
  }

  private void SwigDirectorsetName(string name) {
    setName(name);
  }

  private global::System.IntPtr SwigDirectorinvokeR() {
    return SWIGTYPE_p_void.getCPtr(invokeR()).Handle;
  }

  public delegate void SwigDelegateArRetFunctor_VoidP_0();
  public delegate string SwigDelegateArRetFunctor_VoidP_1();
  public delegate void SwigDelegateArRetFunctor_VoidP_2(string name);
  public delegate global::System.IntPtr SwigDelegateArRetFunctor_VoidP_3();

  private SwigDelegateArRetFunctor_VoidP_0 swigDelegate0;
  private SwigDelegateArRetFunctor_VoidP_1 swigDelegate1;
  private SwigDelegateArRetFunctor_VoidP_2 swigDelegate2;
  private SwigDelegateArRetFunctor_VoidP_3 swigDelegate3;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes2 = new global::System.Type[] { typeof(string) };
  private static global::System.Type[] swigMethodTypes3 = new global::System.Type[] {  };
}

}
