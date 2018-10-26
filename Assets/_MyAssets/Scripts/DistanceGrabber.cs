using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class DistanceGrabber : MonoBehaviour
{
    public VRTK_Pointer pointer;
    public float grabSpeed;
    //public float pullSpeed;

    private GameObject currentSelected;
    private Color highlightColour;
    private float startTime;
    private float journeyLength;
    private bool isPickedUp;

    private void Start()
    {
        currentSelected = null;
        highlightColour = Color.blue;
        isPickedUp = false;
    }

    private void FixedUpdate()
    {
        if (isPickedUp == true)
        {
            currentSelected.transform.position = pointer.pointerRenderer.transform.position;
            //currentSelected.transform.SetParent(pointer.gameObject.transform);
        }
    }

    public void CheckValidToGrab()
    {
        if (pointer.isActiveAndEnabled && pointer.IsStateValid())
        {
            currentSelected = pointer.pointerRenderer.GetDestinationHit().transform.gameObject;
            PickUp();
        }
    }

    public void DropGrabbedObject()
    {
        if (isPickedUp == true)
            Drop();
    }

    private void PickUp()
    {
        isPickedUp = true;
    }

    private void Drop()
    {
        isPickedUp = false;
    }
}
