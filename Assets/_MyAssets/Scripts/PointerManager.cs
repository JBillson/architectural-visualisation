using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class PointerManager : MonoBehaviour
{
    public GameObject[] pointers;
    private GameObject currentPointer;
    private int arrayPos = -1;

    private void Start()
    {
        foreach (GameObject pointer in pointers)
            pointer.SetActive(false);

        currentPointer = null;
    }

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
    }
}
