/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.0
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace OpenTransactions.OTAPI {

public class RippleServer : Server {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal RippleServer(global::System.IntPtr cPtr, bool cMemoryOwn) : base(otapiPINVOKE.RippleServer_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RippleServer obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~RippleServer() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          otapiPINVOKE.delete_RippleServer(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public string gui_label {
    set {
      otapiPINVOKE.RippleServer_gui_label_set(swigCPtr, value);
      if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = otapiPINVOKE.RippleServer_gui_label_get(swigCPtr);
      if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string server_id {
    set {
      otapiPINVOKE.RippleServer_server_id_set(swigCPtr, value);
      if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = otapiPINVOKE.RippleServer_server_id_get(swigCPtr);
      if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string server_type {
    set {
      otapiPINVOKE.RippleServer_server_type_set(swigCPtr, value);
      if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = otapiPINVOKE.RippleServer_server_type_get(swigCPtr);
      if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string server_host {
    set {
      otapiPINVOKE.RippleServer_server_host_set(swigCPtr, value);
      if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = otapiPINVOKE.RippleServer_server_host_get(swigCPtr);
      if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string server_port {
    set {
      otapiPINVOKE.RippleServer_server_port_set(swigCPtr, value);
      if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = otapiPINVOKE.RippleServer_server_port_get(swigCPtr);
      if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string ripple_username {
    set {
      otapiPINVOKE.RippleServer_ripple_username_set(swigCPtr, value);
      if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = otapiPINVOKE.RippleServer_ripple_username_get(swigCPtr);
      if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string ripple_password {
    set {
      otapiPINVOKE.RippleServer_ripple_password_set(swigCPtr, value);
      if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = otapiPINVOKE.RippleServer_ripple_password_get(swigCPtr);
      if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string namefield_id {
    set {
      otapiPINVOKE.RippleServer_namefield_id_set(swigCPtr, value);
      if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = otapiPINVOKE.RippleServer_namefield_id_get(swigCPtr);
      if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string passfield_id {
    set {
      otapiPINVOKE.RippleServer_passfield_id_set(swigCPtr, value);
      if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = otapiPINVOKE.RippleServer_passfield_id_get(swigCPtr);
      if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public new static RippleServer ot_dynamic_cast(Storable pObject) {
    global::System.IntPtr cPtr = otapiPINVOKE.RippleServer_ot_dynamic_cast(Storable.getCPtr(pObject));
    RippleServer ret = (cPtr == global::System.IntPtr.Zero) ? null : new RippleServer(cPtr, false);
    return ret;
  }

}

}
