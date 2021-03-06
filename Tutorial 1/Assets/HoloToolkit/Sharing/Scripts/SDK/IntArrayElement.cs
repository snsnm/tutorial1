/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace HoloToolkit.Sharing {

public class IntArrayElement : Element {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal IntArrayElement(global::System.IntPtr cPtr, bool cMemoryOwn) : base(SharingClientPINVOKE.IntArrayElement_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(IntArrayElement obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~IntArrayElement() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          SharingClientPINVOKE.delete_IntArrayElement(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static IntArrayElement Cast(Element element) {
    global::System.IntPtr cPtr = SharingClientPINVOKE.IntArrayElement_Cast(Element.getCPtr(element));
    IntArrayElement ret = (cPtr == global::System.IntPtr.Zero) ? null : new IntArrayElement(cPtr, true);
    return ret; 
  }

  public virtual int GetCount() {
    int ret = SharingClientPINVOKE.IntArrayElement_GetCount(swigCPtr);
    return ret;
  }

  public virtual int GetValue(int index) {
    int ret = SharingClientPINVOKE.IntArrayElement_GetValue(swigCPtr, index);
    return ret;
  }

  public virtual void SetValue(int index, int newValue) {
    SharingClientPINVOKE.IntArrayElement_SetValue(swigCPtr, index, newValue);
  }

  public virtual void InsertValue(int index, int value) {
    SharingClientPINVOKE.IntArrayElement_InsertValue(swigCPtr, index, value);
  }

  public virtual void RemoveValue(int index) {
    SharingClientPINVOKE.IntArrayElement_RemoveValue(swigCPtr, index);
  }

  public virtual void AddListener(IntArrayListener newListener) {
    SharingClientPINVOKE.IntArrayElement_AddListener(swigCPtr, IntArrayListener.getCPtr(newListener));
  }

  public virtual void RemoveListener(IntArrayListener oldListener) {
    SharingClientPINVOKE.IntArrayElement_RemoveListener(swigCPtr, IntArrayListener.getCPtr(oldListener));
  }

}

}
