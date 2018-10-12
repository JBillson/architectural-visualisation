using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
using VRTK.Highlighters;

public class ObjectEditor : MonoBehaviour
{
    public VRTK_Pointer pointer;
    public GameObject MaterialCubes;

    private GameObject currentSelected;
    private GameObject lastSelected;
    private Color color;

    private void Start()
    {
        MaterialCubes.SetActive(false);
        currentSelected = null;
        lastSelected = null;
        color = Color.yellow;
    }

    //called from VRTK_ControllerEvents_UnityEvents on the RightControllerScriptAlias
    public void CheckValidToEdit()
    {
        //Check if pointer is active and pointing at a valid object
        if (pointer.isActiveAndEnabled && pointer.IsStateValid())
        {
            currentSelected = pointer.pointerRenderer.GetDestinationHit().transform.GetComponentInChildren<Renderer>().gameObject;

            //changeObjectMaterial if currentSelected is a "MaterialCube"
            if (currentSelected.CompareTag("MaterialCube"))
                ChangeMaterial(currentSelected.GetComponent<Renderer>().material);

            //return if object isn't "Editable"
            if (!currentSelected.CompareTag("Editable"))
                return;

            //Determine whether the object is being selected or deselected
            if (currentSelected == lastSelected && MaterialCubes.activeInHierarchy == true)
                DeselectObject();
            else
                SelectObject();
        }
    }

    private void SelectObject()
    {
        if (lastSelected != null)
            RemoveObjectHighlighting(lastSelected);
        
        AddObjectHighlighting(currentSelected);
        ShowMaterialOptions();
        lastSelected = currentSelected;
    }

    private void DeselectObject()
    {
        RemoveObjectHighlighting(currentSelected);
        HideMaterialOptions();
        currentSelected = null;
        lastSelected = null;
    }

    private void AddObjectHighlighting(GameObject go)
    {
        var objectHighlighter = go.gameObject.AddComponent<VRTK_InteractObjectHighlighter>();
        var outline = go.gameObject.AddComponent<VRTK_OutlineObjectCopyHighlighter>();

        outline.thickness = .4f;
        //outline.enableSubmeshHighlight = true;        
        objectHighlighter.Highlight(color);

    }

    private void RemoveObjectHighlighting(GameObject go)
    {
        var objectHighlighter = go.gameObject.GetComponent<VRTK_InteractObjectHighlighter>();
        var outline = go.gameObject.GetComponent<VRTK_OutlineObjectCopyHighlighter>();
        Destroy(objectHighlighter);
        Destroy(outline);
    }

    private void ShowMaterialOptions()
    {
        MaterialCubes.SetActive(true);
    }

    private void HideMaterialOptions()
    {
        MaterialCubes.SetActive(false);
    }

    private void ChangeMaterial(Material material)
    {
        lastSelected.GetComponent<Renderer>().material = material;
    }
}
