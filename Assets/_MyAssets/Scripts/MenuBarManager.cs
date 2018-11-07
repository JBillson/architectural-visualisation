using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class MenuBarManager : MonoBehaviour
{
    public GameObject MenuBar;
    private bool isShowing = true;
    private GameObject player;    

    private void Start()
    {        
        if (MenuBar == null)
            MenuBar = transform.Find("MenuBarHolder").gameObject;                

        HideMenuBar();
    }

    private void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.Start))
        {            
            if (!isShowing)
                ShowMenuBar();
            else
                HideMenuBar();
        }
    }

    private void ShowMenuBar()
    {
        player = VRTK_DeviceFinder.DeviceTransform(VRTK_DeviceFinder.Devices.Headset).gameObject;
        isShowing = true;
        MenuBar.SetActive(true);        
        MenuBar.transform.position = player.transform.position;
        MenuBar.transform.position += new Vector3(0, -0.5f, 0.5f);        
    }

    private void HideMenuBar()
    {
        isShowing = false;
        MenuBar.SetActive(false);
    }
}
