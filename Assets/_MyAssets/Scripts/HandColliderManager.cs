using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandColliderManager : MonoBehaviour
{
    private HandStateManager hsm;

    private SphereCollider fistCollider;
    private CapsuleCollider fingerCollider;    

    private void Start()
    {
        hsm = GetComponentInParent<HandStateManager>();
        fistCollider = GetComponent<SphereCollider>();
        fingerCollider = GetComponent<CapsuleCollider>();
        fistCollider.enabled = false;
        fingerCollider.enabled = false;
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
