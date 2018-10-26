using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandColliderManager : MonoBehaviour
{
    private HandStateManager hsm;

    public SphereCollider fistCollider;
    public CapsuleCollider fingerCollider;
    public SphereCollider vrtkTouchCollider;

    private void Start()
    {
        hsm = GetComponentInParent<HandStateManager>();
        if (fistCollider == null)
            fistCollider = GetComponent<SphereCollider>();
        if (fingerCollider == null)
            fingerCollider = GetComponent<CapsuleCollider>();

        fistCollider.enabled = false;
        fingerCollider.enabled = false;        
    }

    private void Update()
    {
        /////↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓ 
        ///// if (hsm.handState == HandState.Open) 
        /////     vrtkTouchCollider.enabled = true;
        ///// else
        /////     vrtkTouchCollider.enabled = false;
        /////↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑↑  
        vrtkTouchCollider.enabled = (hsm.handState == HandState.Open) ? true : false;        
    }

    public void FistColliderOn()
    {
        fistCollider.enabled = true;
    }

    public void FistColliderOff()
    {
        fistCollider.enabled = false;
    }

    public void FingerColliderOn()
    {
        fingerCollider.enabled = true;
    }

    public void FingerColliderOff()
    {
        fingerCollider.enabled = false;
    }

    public void CollidersOff()
    {
        FistColliderOff();
        FingerColliderOff();
    }
}
