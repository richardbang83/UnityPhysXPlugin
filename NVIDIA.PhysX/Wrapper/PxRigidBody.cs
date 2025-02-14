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

public partial class PxRigidBody : PxRigidActor {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PxRigidBody(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NativePINVOKE.PxRigidBody_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PxRigidBody obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static new PxRigidBody getWrapper(global::System.IntPtr cPtr, bool cMemoryOwn) {
      var wrapper = WrapperCache.find(cPtr);
      if (!(wrapper is PxRigidBody)) {
          wrapper = new PxRigidBody(cPtr, cMemoryOwn);
          WrapperCache.add(cPtr, wrapper);
      }
      return wrapper as PxRigidBody;
  }

  public void setCMassLocalPose( PxTransform  pose) {
    NativePINVOKE.PxRigidBody_setCMassLocalPose(swigCPtr,  pose.swigCPtr );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public  PxTransform  getCMassLocalPose() {
        global::System.IntPtr ptr = NativePINVOKE.PxRigidBody_getCMassLocalPose(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxTransform ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxTransform>(ptr);
        PxTransform ret; unsafe { ret = *(PxTransform*)ptr; }
        return ret;
    }

  public void setMass(float mass) {
    NativePINVOKE.PxRigidBody_setMass(swigCPtr, mass);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public float getMass() {
    float ret = NativePINVOKE.PxRigidBody_getMass(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float getInvMass() {
    float ret = NativePINVOKE.PxRigidBody_getInvMass(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setMassSpaceInertiaTensor( PxVec3  m) {
    NativePINVOKE.PxRigidBody_setMassSpaceInertiaTensor(swigCPtr,  m.swigCPtr );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public  PxVec3  getMassSpaceInertiaTensor() {
        global::System.IntPtr ptr = NativePINVOKE.PxRigidBody_getMassSpaceInertiaTensor(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxVec3 ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxVec3>(ptr);
        PxVec3 ret; unsafe { ret = *(PxVec3*)ptr; }
        return ret;
    }

  public  PxVec3  getMassSpaceInvInertiaTensor() {
        global::System.IntPtr ptr = NativePINVOKE.PxRigidBody_getMassSpaceInvInertiaTensor(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxVec3 ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxVec3>(ptr);
        PxVec3 ret; unsafe { ret = *(PxVec3*)ptr; }
        return ret;
    }

  public void setLinearDamping(float linDamp) {
    NativePINVOKE.PxRigidBody_setLinearDamping(swigCPtr, linDamp);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public float getLinearDamping() {
    float ret = NativePINVOKE.PxRigidBody_getLinearDamping(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setAngularDamping(float angDamp) {
    NativePINVOKE.PxRigidBody_setAngularDamping(swigCPtr, angDamp);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public float getAngularDamping() {
    float ret = NativePINVOKE.PxRigidBody_getAngularDamping(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public  PxVec3  getLinearVelocity() {
        global::System.IntPtr ptr = NativePINVOKE.PxRigidBody_getLinearVelocity(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxVec3 ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxVec3>(ptr);
        PxVec3 ret; unsafe { ret = *(PxVec3*)ptr; }
        return ret;
    }

  public void setLinearVelocity( PxVec3  linVel, bool autowake) {
    NativePINVOKE.PxRigidBody_setLinearVelocity__SWIG_0(swigCPtr,  linVel.swigCPtr , autowake);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setLinearVelocity( PxVec3  linVel) {
    NativePINVOKE.PxRigidBody_setLinearVelocity__SWIG_1(swigCPtr,  linVel.swigCPtr );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public  PxVec3  getAngularVelocity() {
        global::System.IntPtr ptr = NativePINVOKE.PxRigidBody_getAngularVelocity(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxVec3 ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxVec3>(ptr);
        PxVec3 ret; unsafe { ret = *(PxVec3*)ptr; }
        return ret;
    }

  public void setAngularVelocity( PxVec3  angVel, bool autowake) {
    NativePINVOKE.PxRigidBody_setAngularVelocity__SWIG_0(swigCPtr,  angVel.swigCPtr , autowake);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setAngularVelocity( PxVec3  angVel) {
    NativePINVOKE.PxRigidBody_setAngularVelocity__SWIG_1(swigCPtr,  angVel.swigCPtr );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setMaxAngularVelocity(float maxAngVel) {
    NativePINVOKE.PxRigidBody_setMaxAngularVelocity(swigCPtr, maxAngVel);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public float getMaxAngularVelocity() {
    float ret = NativePINVOKE.PxRigidBody_getMaxAngularVelocity(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setMaxLinearVelocity(float maxLinVel) {
    NativePINVOKE.PxRigidBody_setMaxLinearVelocity(swigCPtr, maxLinVel);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public float getMaxLinearVelocity() {
    float ret = NativePINVOKE.PxRigidBody_getMaxLinearVelocity(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void addForce( PxVec3  force, PxForceMode mode, bool autowake) {
    NativePINVOKE.PxRigidBody_addForce__SWIG_0(swigCPtr,  force.swigCPtr , (int)mode, autowake);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void addForce( PxVec3  force, PxForceMode mode) {
    NativePINVOKE.PxRigidBody_addForce__SWIG_1(swigCPtr,  force.swigCPtr , (int)mode);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void addForce( PxVec3  force) {
    NativePINVOKE.PxRigidBody_addForce__SWIG_2(swigCPtr,  force.swigCPtr );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void addTorque( PxVec3  torque, PxForceMode mode, bool autowake) {
    NativePINVOKE.PxRigidBody_addTorque__SWIG_0(swigCPtr,  torque.swigCPtr , (int)mode, autowake);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void addTorque( PxVec3  torque, PxForceMode mode) {
    NativePINVOKE.PxRigidBody_addTorque__SWIG_1(swigCPtr,  torque.swigCPtr , (int)mode);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void addTorque( PxVec3  torque) {
    NativePINVOKE.PxRigidBody_addTorque__SWIG_2(swigCPtr,  torque.swigCPtr );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void clearForce(PxForceMode mode) {
    NativePINVOKE.PxRigidBody_clearForce__SWIG_0(swigCPtr, (int)mode);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void clearForce() {
    NativePINVOKE.PxRigidBody_clearForce__SWIG_1(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void clearTorque(PxForceMode mode) {
    NativePINVOKE.PxRigidBody_clearTorque__SWIG_0(swigCPtr, (int)mode);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void clearTorque() {
    NativePINVOKE.PxRigidBody_clearTorque__SWIG_1(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setForceAndTorque( PxVec3  force,  PxVec3  torque, PxForceMode mode) {
    NativePINVOKE.PxRigidBody_setForceAndTorque__SWIG_0(swigCPtr,  force.swigCPtr ,  torque.swigCPtr , (int)mode);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setForceAndTorque( PxVec3  force,  PxVec3  torque) {
    NativePINVOKE.PxRigidBody_setForceAndTorque__SWIG_1(swigCPtr,  force.swigCPtr ,  torque.swigCPtr );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setRigidBodyFlag(PxRigidBodyFlag flag, bool value) {
    NativePINVOKE.PxRigidBody_setRigidBodyFlag(swigCPtr, (int)flag, value);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setRigidBodyFlags(PxRigidBodyFlag inFlags) {
    NativePINVOKE.PxRigidBody_setRigidBodyFlags(swigCPtr, (int)inFlags);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public PxRigidBodyFlag getRigidBodyFlags() {
    PxRigidBodyFlag ret = (PxRigidBodyFlag)NativePINVOKE.PxRigidBody_getRigidBodyFlags(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setMinCCDAdvanceCoefficient(float advanceCoefficient) {
    NativePINVOKE.PxRigidBody_setMinCCDAdvanceCoefficient(swigCPtr, advanceCoefficient);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public float getMinCCDAdvanceCoefficient() {
    float ret = NativePINVOKE.PxRigidBody_getMinCCDAdvanceCoefficient(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setMaxDepenetrationVelocity(float biasClamp) {
    NativePINVOKE.PxRigidBody_setMaxDepenetrationVelocity(swigCPtr, biasClamp);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public float getMaxDepenetrationVelocity() {
    float ret = NativePINVOKE.PxRigidBody_getMaxDepenetrationVelocity(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setMaxContactImpulse(float maxImpulse) {
    NativePINVOKE.PxRigidBody_setMaxContactImpulse(swigCPtr, maxImpulse);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public float getMaxContactImpulse() {
    float ret = NativePINVOKE.PxRigidBody_getMaxContactImpulse(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool updateMassAndInertia(float[] shapeDensities, uint shapeDensityCount,  PxVec3  massLocalPose, bool includeNonSimShapes) {
    bool ret = NativePINVOKE.PxRigidBody_updateMassAndInertia__SWIG_0(swigCPtr, shapeDensities, shapeDensityCount,  massLocalPose.swigCPtr , includeNonSimShapes);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool updateMassAndInertia(float[] shapeDensities, uint shapeDensityCount,  PxVec3  massLocalPose) {
    bool ret = NativePINVOKE.PxRigidBody_updateMassAndInertia__SWIG_1(swigCPtr, shapeDensities, shapeDensityCount,  massLocalPose.swigCPtr );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool updateMassAndInertia(float[] shapeDensities, uint shapeDensityCount) {
    bool ret = NativePINVOKE.PxRigidBody_updateMassAndInertia__SWIG_2(swigCPtr, shapeDensities, shapeDensityCount);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool updateMassAndInertia(float density,  PxVec3  massLocalPose, bool includeNonSimShapes) {
    bool ret = NativePINVOKE.PxRigidBody_updateMassAndInertia__SWIG_3(swigCPtr, density,  massLocalPose.swigCPtr , includeNonSimShapes);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool updateMassAndInertia(float density,  PxVec3  massLocalPose) {
    bool ret = NativePINVOKE.PxRigidBody_updateMassAndInertia__SWIG_4(swigCPtr, density,  massLocalPose.swigCPtr );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool updateMassAndInertia(float density) {
    bool ret = NativePINVOKE.PxRigidBody_updateMassAndInertia__SWIG_5(swigCPtr, density);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool updateMassAndInertia() {
    bool ret = NativePINVOKE.PxRigidBody_updateMassAndInertia__SWIG_6(swigCPtr);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool setMassAndUpdateInertia(float[] shapeMasses, uint shapeMassCount,  PxVec3  massLocalPose, bool includeNonSimShapes) {
    bool ret = NativePINVOKE.PxRigidBody_setMassAndUpdateInertia__SWIG_0(swigCPtr, shapeMasses, shapeMassCount,  massLocalPose.swigCPtr , includeNonSimShapes);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool setMassAndUpdateInertia(float[] shapeMasses, uint shapeMassCount,  PxVec3  massLocalPose) {
    bool ret = NativePINVOKE.PxRigidBody_setMassAndUpdateInertia__SWIG_1(swigCPtr, shapeMasses, shapeMassCount,  massLocalPose.swigCPtr );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool setMassAndUpdateInertia(float[] shapeMasses, uint shapeMassCount) {
    bool ret = NativePINVOKE.PxRigidBody_setMassAndUpdateInertia__SWIG_2(swigCPtr, shapeMasses, shapeMassCount);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool setMassAndUpdateInertia(float mass,  PxVec3  massLocalPose, bool includeNonSimShapes) {
    bool ret = NativePINVOKE.PxRigidBody_setMassAndUpdateInertia__SWIG_3(swigCPtr, mass,  massLocalPose.swigCPtr , includeNonSimShapes);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool setMassAndUpdateInertia(float mass,  PxVec3  massLocalPose) {
    bool ret = NativePINVOKE.PxRigidBody_setMassAndUpdateInertia__SWIG_4(swigCPtr, mass,  massLocalPose.swigCPtr );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool setMassAndUpdateInertia(float mass) {
    bool ret = NativePINVOKE.PxRigidBody_setMassAndUpdateInertia__SWIG_5(swigCPtr, mass);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static  PxMassProperties  computeMassPropertiesFromShapes(PxShape[] shapes, int shapeCount) {
        global::System.IntPtr ptr = NativePINVOKE.PxRigidBody_computeMassPropertiesFromShapes(global::System.Array.ConvertAll(shapes, x => PxShape.getCPtr(x)), shapeCount);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxMassProperties ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxMassProperties>(ptr);
        PxMassProperties ret; unsafe { ret = *(PxMassProperties*)ptr; }
        return ret;
    }

  public void addForceAtPos( PxVec3  force,  PxVec3  pos, PxForceMode mode, bool wakeup) {
    NativePINVOKE.PxRigidBody_addForceAtPos__SWIG_0(swigCPtr,  force.swigCPtr ,  pos.swigCPtr , (int)mode, wakeup);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void addForceAtPos( PxVec3  force,  PxVec3  pos, PxForceMode mode) {
    NativePINVOKE.PxRigidBody_addForceAtPos__SWIG_1(swigCPtr,  force.swigCPtr ,  pos.swigCPtr , (int)mode);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void addForceAtPos( PxVec3  force,  PxVec3  pos) {
    NativePINVOKE.PxRigidBody_addForceAtPos__SWIG_2(swigCPtr,  force.swigCPtr ,  pos.swigCPtr );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void addForceAtLocalPos( PxVec3  force,  PxVec3  pos, PxForceMode mode, bool wakeup) {
    NativePINVOKE.PxRigidBody_addForceAtLocalPos__SWIG_0(swigCPtr,  force.swigCPtr ,  pos.swigCPtr , (int)mode, wakeup);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void addForceAtLocalPos( PxVec3  force,  PxVec3  pos, PxForceMode mode) {
    NativePINVOKE.PxRigidBody_addForceAtLocalPos__SWIG_1(swigCPtr,  force.swigCPtr ,  pos.swigCPtr , (int)mode);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void addForceAtLocalPos( PxVec3  force,  PxVec3  pos) {
    NativePINVOKE.PxRigidBody_addForceAtLocalPos__SWIG_2(swigCPtr,  force.swigCPtr ,  pos.swigCPtr );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void addLocalForceAtPos( PxVec3  force,  PxVec3  pos, PxForceMode mode, bool wakeup) {
    NativePINVOKE.PxRigidBody_addLocalForceAtPos__SWIG_0(swigCPtr,  force.swigCPtr ,  pos.swigCPtr , (int)mode, wakeup);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void addLocalForceAtPos( PxVec3  force,  PxVec3  pos, PxForceMode mode) {
    NativePINVOKE.PxRigidBody_addLocalForceAtPos__SWIG_1(swigCPtr,  force.swigCPtr ,  pos.swigCPtr , (int)mode);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void addLocalForceAtPos( PxVec3  force,  PxVec3  pos) {
    NativePINVOKE.PxRigidBody_addLocalForceAtPos__SWIG_2(swigCPtr,  force.swigCPtr ,  pos.swigCPtr );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void addLocalForceAtLocalPos( PxVec3  force,  PxVec3  pos, PxForceMode mode, bool wakeup) {
    NativePINVOKE.PxRigidBody_addLocalForceAtLocalPos__SWIG_0(swigCPtr,  force.swigCPtr ,  pos.swigCPtr , (int)mode, wakeup);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void addLocalForceAtLocalPos( PxVec3  force,  PxVec3  pos, PxForceMode mode) {
    NativePINVOKE.PxRigidBody_addLocalForceAtLocalPos__SWIG_1(swigCPtr,  force.swigCPtr ,  pos.swigCPtr , (int)mode);
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void addLocalForceAtLocalPos( PxVec3  force,  PxVec3  pos) {
    NativePINVOKE.PxRigidBody_addLocalForceAtLocalPos__SWIG_2(swigCPtr,  force.swigCPtr ,  pos.swigCPtr );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public  PxVec3  getVelocityAtPos( PxVec3  pos) {
        global::System.IntPtr ptr = NativePINVOKE.PxRigidBody_getVelocityAtPos(swigCPtr,  pos.swigCPtr );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxVec3 ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxVec3>(ptr);
        PxVec3 ret; unsafe { ret = *(PxVec3*)ptr; }
        return ret;
    }

  public  PxVec3  getLocalVelocityAtLocalPos( PxVec3  pos) {
        global::System.IntPtr ptr = NativePINVOKE.PxRigidBody_getLocalVelocityAtLocalPos(swigCPtr,  pos.swigCPtr );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxVec3 ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxVec3>(ptr);
        PxVec3 ret; unsafe { ret = *(PxVec3*)ptr; }
        return ret;
    }

  public  PxVec3  getVelocityAtOffset( PxVec3  pos) {
        global::System.IntPtr ptr = NativePINVOKE.PxRigidBody_getVelocityAtOffset(swigCPtr,  pos.swigCPtr );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
        //PxVec3 ret = global::System.Runtime.InteropServices.Marshal.PtrToStructure<PxVec3>(ptr);
        PxVec3 ret; unsafe { ret = *(PxVec3*)ptr; }
        return ret;
    }

  public void computeVelocityDeltaFromImpulse( PxVec3  impulsiveForce,  PxVec3  impulsiveTorque,  out PxVec3  deltaLinearVelocity,  out PxVec3  deltaAngularVelocity) {
    NativePINVOKE.PxRigidBody_computeVelocityDeltaFromImpulse__SWIG_0(swigCPtr,  impulsiveForce.swigCPtr ,  impulsiveTorque.swigCPtr ,  out deltaLinearVelocity ,  out deltaAngularVelocity );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void computeVelocityDeltaFromImpulse( PxTransform  globalPose,  PxVec3  point,  PxVec3  impulse, float invMassScale, float invInertiaScale,  out PxVec3  deltaLinearVelocity,  out PxVec3  deltaAngularVelocity) {
    NativePINVOKE.PxRigidBody_computeVelocityDeltaFromImpulse__SWIG_1(swigCPtr,  globalPose.swigCPtr ,  point.swigCPtr ,  impulse.swigCPtr , invMassScale, invInertiaScale,  out deltaLinearVelocity ,  out deltaAngularVelocity );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void computeLinearAngularImpulse( PxTransform  globalPose,  PxVec3  point,  PxVec3  impulse, float invMassScale, float invInertiaScale,  out PxVec3  linearImpulse,  out PxVec3  angularImpulse) {
    NativePINVOKE.PxRigidBody_computeLinearAngularImpulse(swigCPtr,  globalPose.swigCPtr ,  point.swigCPtr ,  impulse.swigCPtr , invMassScale, invInertiaScale,  out linearImpulse ,  out angularImpulse );
    if (NativePINVOKE.SWIGPendingException.Pending) throw NativePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
