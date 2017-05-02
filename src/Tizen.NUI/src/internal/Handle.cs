/** Copyright (c) 2017 Samsung Electronics Co., Ltd.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/
// This File has been auto-generated by SWIG and then modified using DALi Ruby Scripts
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

public class Handle : BaseHandle {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal Handle(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NDalicPINVOKE.Handle_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Handle obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }


  public override void Dispose() {
    if (!Stage.IsInstalled()) {
      DisposeQueue.Instance.Add(this);
      return;
    }

    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NDalicPINVOKE.delete_Handle(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }


  public Handle () : this (NDalicPINVOKE.Handle_New(), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();

  }
  public Handle(Handle handle) : this(NDalicPINVOKE.new_Handle__SWIG_1(Handle.getCPtr(handle)), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public Handle Assign(Handle rhs) {
    Handle ret = new Handle(NDalicPINVOKE.Handle_Assign(swigCPtr, Handle.getCPtr(rhs)), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Handle DownCast(BaseHandle handle) {
    Handle ret = new Handle(NDalicPINVOKE.Handle_DownCast(BaseHandle.getCPtr(handle)), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Supports(Handle.Capability capability) {
    bool ret = NDalicPINVOKE.Handle_Supports(swigCPtr, (int)capability);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetPropertyCount() {
    uint ret = NDalicPINVOKE.Handle_GetPropertyCount(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetPropertyName(int index) {
    string ret = NDalicPINVOKE.Handle_GetPropertyName(swigCPtr, index);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetPropertyIndex(string name) {
    int ret = NDalicPINVOKE.Handle_GetPropertyIndex(swigCPtr, name);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsPropertyWritable(int index) {
    bool ret = NDalicPINVOKE.Handle_IsPropertyWritable(swigCPtr, index);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsPropertyAnimatable(int index) {
    bool ret = NDalicPINVOKE.Handle_IsPropertyAnimatable(swigCPtr, index);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsPropertyAConstraintInput(int index) {
    bool ret = NDalicPINVOKE.Handle_IsPropertyAConstraintInput(swigCPtr, index);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PropertyType GetPropertyType(int index) {
    PropertyType ret = (PropertyType)NDalicPINVOKE.Handle_GetPropertyType(swigCPtr, index);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetProperty(int index, PropertyValue propertyValue) {
    NDalicPINVOKE.Handle_SetProperty(swigCPtr, index, PropertyValue.getCPtr(propertyValue));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public int RegisterProperty(string name, PropertyValue propertyValue) {
    int ret = NDalicPINVOKE.Handle_RegisterProperty__SWIG_0(swigCPtr, name, PropertyValue.getCPtr(propertyValue));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int RegisterProperty(string name, PropertyValue propertyValue, PropertyAccessMode accessMode) {
    int ret = NDalicPINVOKE.Handle_RegisterProperty__SWIG_1(swigCPtr, name, PropertyValue.getCPtr(propertyValue), (int)accessMode);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PropertyValue GetProperty(int index) {
    PropertyValue ret = new PropertyValue(NDalicPINVOKE.Handle_GetProperty(swigCPtr, index), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

        internal void GetPropertyIndices(VectorInteger indices)
        {
            NDalicPINVOKE.Handle_GetPropertyIndices(swigCPtr, VectorInteger.getCPtr(indices));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        internal PropertyNotification AddPropertyNotification(int index, PropertyCondition condition)
        {
            PropertyNotification ret = new PropertyNotification(NDalicPINVOKE.Handle_AddPropertyNotification__SWIG_0(swigCPtr, index, PropertyCondition.getCPtr(condition)), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal PropertyNotification AddPropertyNotification(int index, int componentIndex, PropertyCondition condition)
        {
            PropertyNotification ret = new PropertyNotification(NDalicPINVOKE.Handle_AddPropertyNotification__SWIG_1(swigCPtr, index, componentIndex, PropertyCondition.getCPtr(condition)), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal void RemovePropertyNotification(PropertyNotification propertyNotification)
        {
            NDalicPINVOKE.Handle_RemovePropertyNotification(swigCPtr, PropertyNotification.getCPtr(propertyNotification));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

  public void RemovePropertyNotifications() {
    NDalicPINVOKE.Handle_RemovePropertyNotifications(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveConstraints() {
    NDalicPINVOKE.Handle_RemoveConstraints__SWIG_0(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveConstraints(uint tag) {
    NDalicPINVOKE.Handle_RemoveConstraints__SWIG_1(swigCPtr, tag);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public enum Capability {
    DYNAMIC_PROPERTIES = 0x01
  }

}

}
