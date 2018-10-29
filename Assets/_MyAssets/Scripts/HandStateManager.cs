using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class HandStateManager : MonoBehaviour
{
    public HandState handState = HandState.Open;
    private VRTK_ControllerEvents cE;
    private HandColliderManager hcm;
    
    private void Start()
    {
        cE = GetComponentInParent<VRTK_ControllerEvents>();
        hcm = GetComponentInChildren<HandColliderManager>();
    }
  
    public void Update()
    {       
        if (!cE.gripPressed)
        {
            if (cE.triggerPressed && (cE.touchpadTouched || cE.buttonOneTouched || cE.buttonTwoTouched || OVRInput.Get(OVRInput.Touch.PrimaryThumbRest)))
                Pinch();
            else
                OpenHands();
        }

        if (cE.gripPressed && cE.triggerTouched)
        {
            if (cE.touchpadTouched || cE.buttonOneTouched || cE.buttonTwoTouched || OVRInput.Get(OVRInput.Touch.PrimaryThumbRest))
                CloseHands();
            else
                ThumbUp();
        }

        if (cE.gripPressed && !cE.triggerTouched)
        {
            if (cE.touchpadTouched || cE.buttonOneTouched || cE.buttonTwoTouched || OVRInput.Get(OVRInput.Touch.PrimaryThumbRest))
                Point();
            else
                PointWithThumbUp();
        }        
    }
    
    private void CloseHands()
    {
        if (handState == HandState.Closed)
            return;
      
        handState = HandState.Closed;
        hcm.FistColliderOn();
        hcm.FingerColliderOff();
    }

    private void OpenHands()
    {
        if (handState == HandState.Open)
            return;

        handState = HandState.Open;
        hcm.CollidersOff();
    }

    private void Point()
    {
        if (handState == HandState.Point)
            return;

        handState = HandState.Point;
        hcm.FistColliderOff();
        hcm.FingerColliderOn();        
    }

    private void ThumbUp()
    {
        if (handState == HandState.ThumbUp)
            return;

        handState = HandState.ThumbUp;
    }

    private void PointWithThumbUp()
    {
        if (handState == HandState.PointWithThumbUp)
            return;

        handState = HandState.PointWithThumbUp;
        hcm.FistColliderOff();
        hcm.FingerColliderOn();
    }

    private void Pinch()
    {
        if (handState == HandState.Pinch)
            return;

        handState = HandState.Pinch;
        hcm.CollidersOff();
    }
}

public enum HandState{
    Open,
    Closed,
    Point,
    ThumbUp,
    PointWithThumbUp,
    Pinch
}
