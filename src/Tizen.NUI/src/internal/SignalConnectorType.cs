//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.9
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Tizen.NUI {

    internal class SignalConnectorType : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SignalConnectorType(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SignalConnectorType obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SignalConnectorType() {
    DisposeQueue.Instance.Add(this);
  }

  public virtual void Dispose() {

    if (!Stage.IsInstalled()) {
      DisposeQueue.Instance.Add(this);
      return;
    }

    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NDalicPINVOKE.delete_SignalConnectorType(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SignalConnectorType(TypeRegistration typeRegistration, string name, SWIGTYPE_p_f_p_Dali__BaseObject_p_Dali__ConnectionTrackerInterface_r_q_const__std__string_p_Dali__FunctorDelegate__bool func) : this(NDalicPINVOKE.new_SignalConnectorType(TypeRegistration.getCPtr(typeRegistration), name, SWIGTYPE_p_f_p_Dali__BaseObject_p_Dali__ConnectionTrackerInterface_r_q_const__std__string_p_Dali__FunctorDelegate__bool.getCPtr(func)), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
