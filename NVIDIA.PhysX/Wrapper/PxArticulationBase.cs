//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace NVIDIA.PhysX {

public partial class PxArticulationBase : PxBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PxArticulationBase(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NativePINVOKE.PxArticulationBase_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxArticulationBase obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static new PxArticulationBase getWrapper(global::System.IntPtr cPtr, bool cMemoryOwn) {
      var wrapper = WrapperCache.find(cPtr);
      if (!(wrapper is PxArticulationBase)) {
          wrapper = new PxArticulationBase(cPtr, cMemoryOwn);
          WrapperCache.add(cPtr, wrapper);
      }
      return wrapper as PxArticulationBase;
  }

  public PxScene getScene() {
    global::System.IntPtr cPtr = NativePINVOKE.PxArticulationBase_getScene(swigCPtr);
    PxScene ret = (cPtr == global::System.IntPtr.Zero) ? null : PxScene.getWrapper(cPtr, false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setSolverIterationCounts(uint minPositionIters, uint minVelocityIters) {
    NativePINVOKE.PxArticulationBase_setSolverIterationCounts__SWIG_0(swigCPtr, minPositionIters, minVelocityIters);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setSolverIterationCounts(uint minPositionIters) {
    NativePINVOKE.PxArticulationBase_setSolverIterationCounts__SWIG_1(swigCPtr, minPositionIters);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void getSolverIterationCounts(out uint minPositionIters, out uint minVelocityIters) {
    NativePINVOKE.PxArticulationBase_getSolverIterationCounts(swigCPtr, out minPositionIters, out minVelocityIters);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isSleeping() {
    bool ret = NativePINVOKE.PxArticulationBase_isSleeping(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setSleepThreshold(float threshold) {
    NativePINVOKE.PxArticulationBase_setSleepThreshold(swigCPtr, threshold);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public float getSleepThreshold() {
    float ret = NativePINVOKE.PxArticulationBase_getSleepThreshold(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setStabilizationThreshold(float threshold) {
    NativePINVOKE.PxArticulationBase_setStabilizationThreshold(swigCPtr, threshold);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public float getStabilizationThreshold() {
    float ret = NativePINVOKE.PxArticulationBase_getStabilizationThreshold(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setWakeCounter(float wakeCounterValue) {
    NativePINVOKE.PxArticulationBase_setWakeCounter(swigCPtr, wakeCounterValue);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public float getWakeCounter() {
    float ret = NativePINVOKE.PxArticulationBase_getWakeCounter(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void wakeUp() {
    NativePINVOKE.PxArticulationBase_wakeUp(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void putToSleep() {
    NativePINVOKE.PxArticulationBase_putToSleep(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public PxArticulationLink createLink(PxArticulationLink parent,  PxTransform  pose) {
    global::System.IntPtr cPtr = NativePINVOKE.PxArticulationBase_createLink(swigCPtr, PxArticulationLink.getCPtr(parent),  pose.swigCPtr );
    PxArticulationLink ret = (cPtr == global::System.IntPtr.Zero) ? null : PxArticulationLink.getWrapper(cPtr, false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxArticulationLink getLink(uint index) {
    global::System.IntPtr cPtr = NativePINVOKE.PxArticulationBase_getLink(swigCPtr, index);
    PxArticulationLink ret = (cPtr == global::System.IntPtr.Zero) ? null : PxArticulationLink.getWrapper(cPtr, false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setName(string name) {
    NativePINVOKE.PxArticulationBase_setName(swigCPtr, name);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public string getName() {
    string ret = NativePINVOKE.PxArticulationBase_getName(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public  PxBounds3  getWorldBounds(float inflation) {
        global::System.IntPtr ptr = NativePINVOKE.PxArticulationBase_getWorldBounds__SWIG_0(swigCPtr, inflation);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxBounds3 ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxBounds3>(ptr);
        PxBounds3 ret; unsafe { ret = *(PxBounds3*)ptr; }
        return ret;
    }

  public  PxBounds3  getWorldBounds() {
        global::System.IntPtr ptr = NativePINVOKE.PxArticulationBase_getWorldBounds__SWIG_1(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxBounds3 ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxBounds3>(ptr);
        PxBounds3 ret; unsafe { ret = *(PxBounds3*)ptr; }
        return ret;
    }

  public PxAggregate getAggregate() {
    global::System.IntPtr cPtr = NativePINVOKE.PxArticulationBase_getAggregate(swigCPtr);
    PxAggregate ret = (cPtr == global::System.IntPtr.Zero) ? null : PxAggregate.getWrapper(cPtr, false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PxArticulationJointBase createArticulationJoint(PxArticulationLink parent,  PxTransform  parentFrame, PxArticulationLink child,  PxTransform  childFrame) {
    global::System.IntPtr cPtr = NativePINVOKE.PxArticulationBase_createArticulationJoint(swigCPtr, PxArticulationLink.getCPtr(parent),  parentFrame.swigCPtr , PxArticulationLink.getCPtr(child),  childFrame.swigCPtr );
    PxArticulationJointBase ret = (cPtr == global::System.IntPtr.Zero) ? null : PxArticulationJointBase.getWrapper(cPtr, false);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void releaseArticulationJoint(PxArticulationJointBase joint) {
    NativePINVOKE.PxArticulationBase_releaseArticulationJoint(swigCPtr, PxArticulationJointBase.getCPtr(joint));
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
