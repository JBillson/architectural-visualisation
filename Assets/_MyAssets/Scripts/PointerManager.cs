using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class PointerManager : MonoBehaviour
{
    public GameObject[] pointers;
    private GameObject currentPointer;
    private int arrayPos = -1;
    private ObjectEditor objEditor;

    private void Start()
    {
        objEditor = GetComponentInChildren<ObjectEditor>();
        foreach (GameObject pointer in pointers)
            pointer.SetActive(false);

        currentPointer = null;
    }

    //called from the controller events on the RightControllerScriptAlias
    public void CycleThroughPointers()
    {        
        if (currentPointer != null)
            currentPointer.SetActive(false);

        if (arrayPos >= pointers.Length - 1)
            arrayPos = -1;
        else
            arrayPos += 1;

        if (arrayPos == -1)
        {
            foreach (GameObject pointer in pointers)
                pointer.SetActive(false);
        }
        else
        {
            currentPointer = pointers[arrayPos];
            currentPointer.SetActive(true);
        }

        if (currentPointer.GetComponent<ObjectEditor>() == null)    
            objEditor.DeselectObject();
    }
}