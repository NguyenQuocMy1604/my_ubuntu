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

public class ArRetFunctor_Int : ArFunctor {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  public ArRetFunctor_Int(global::System.IntPtr cPtr, bool cMemoryOwn) : base(AriaCSPINVOKE.ArRetFunctor_Int_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ArRetFunctor_Int obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ArRetFunctor_Int() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AriaCSPINVOKE.delete_ArRetFunctor_Int(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public override void invoke() {
    if (SwigDerivedClassHasMethod("invoke", swigMethodTypes0)) AriaCSPINVOKE.ArRetFunctor_Int_invokeSwigExplicitArRetFunctor_Int(swigCPtr); else AriaCSPINVOKE.ArRetFunctor_Int_invoke(swigCPtr);
  }

  public virtual int invokeR() {
    int ret = AriaCSPINVOKE.ArRetFunctor_Int_invokeR(swigCPtr);
    return ret;
  }

  public ArRetFunctor_Int() : this(AriaCSPINVOKE.new_ArRetFunctor_Int(), true) {
    SwigDirectorConnect();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("invoke", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateArRetFunctor_Int_0(SwigDirectorinvoke);
    if (SwigDerivedClassHasMethod("getName", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateArRetFunctor_Int_1(SwigDirectorgetName);
    if (SwigDerivedClassHasMethod("setName", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateArRetFunctor_Int_2(SwigDirectorsetName);
    if (SwigDerivedClassHasMethod("invokeR", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateArRetFunctor_Int_3(SwigDirectorinvokeR);
    AriaCSPINVOKE.ArRetFunctor_Int_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(ArRetFunctor_Int));
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

  private int SwigDirectorinvokeR() {
    return invokeR();
  }

  public delegate void SwigDelegateArRetFunctor_Int_0();
  public delegate string SwigDelegateArRetFunctor_Int_1();
  public delegate void SwigDelegateArRetFunctor_Int_2(string name);
  public delegate int SwigDelegateArRetFunctor_Int_3();

  private SwigDelegateArRetFunctor_Int_0 swigDelegate0;
  private SwigDelegateArRetFunctor_Int_1 swigDelegate1;
  private SwigDelegateArRetFunctor_Int_2 swigDelegate2;
  private SwigDelegateArRetFunctor_Int_3 swigDelegate3;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes2 = new global::System.Type[] { typeof(string) };
  private static global::System.Type[] swigMethodTypes3 = new global::System.Type[] {  };
}

}
