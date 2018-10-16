using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
using VRTK.Highlighters;

public class ObjectEditor : MonoBehaviour
{
    public VRTK_Pointer pointer;

    public GameObject MaterialCubePrefab;
    public GameObject MaterialOptionsHolder;

    private GameObject currentSelected;
    private GameObject lastSelected;
    private Color highlightColour;
    private Vector3 pointPos;

    private void Start()
    {
        currentSelected = null;
        lastSelected = null;
        highlightColour = Color.yellow;
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
            if (currentSelected == lastSelected && currentSelected.GetComponent<VRTK_OutlineObjectCopyHighlighter>())
                DeselectObject();
            else
                SelectObject();
        }
    }

    private void SelectObject()
    {
        if (lastSelected != null)
            RemoveObjectHighlighting(lastSelected);

        DestroyMaterialOptions();
        AddObjectHighlighting(currentSelected);
        SpawnMaterialOptions();
        lastSelected = currentSelected;
    }

    private void DeselectObject()
    {
        RemoveObjectHighlighting(currentSelected);
        DestroyMaterialOptions();
        currentSelected = null;
        lastSelected = null;
    }

    private void AddObjectHighlighting(GameObject go)
    {
        var objectHighlighter = go.gameObject.AddComponent<VRTK_InteractObjectHighlighter>();
        var outline = go.gameObject.AddComponent<VRTK_OutlineObjectCopyHighlighter>();
        var interactableObject = go.gameObject.AddComponent<VRTK_InteractableObject>();

        outline.thickness = .4f;
        objectHighlighter.Highlight(highlightColour);

    }

    private void RemoveObjectHighlighting(GameObject go)
    {
        var objectHighlighter = go.gameObject.GetComponent<VRTK_InteractObjectHighlighter>();
        var outline = go.gameObject.GetComponent<VRTK_OutlineObjectCopyHighlighter>();
        var interactableObject = go.gameObject.GetComponent<VRTK_InteractableObject>();
        Destroy(objectHighlighter);
        Destroy(outline);
        Destroy(interactableObject);
    }

    private void SpawnMaterialOptions()
    {
        if (!currentSelected.GetComponent<ObjectMaterialOptions>() || currentSelected.GetComponent<ObjectMaterialOptions>().materials.Length == 0)
        {
            Debug.LogError("Object is editable but has no materials to change to");
            return;
        }   
            
        var numOfMaterials = currentSelected.GetComponent<ObjectMaterialOptions>().materials.Length;
        for (int i = 0; i < numOfMaterials; i++)
        {
            float pointNum = (i * 1.0f) / numOfMaterials;
            float angle = pointNum * Mathf.PI * 2;

            var radius = 0f;

            if (numOfMaterials < 4)
                radius = .1f;
            else
                radius = .15f;


            float x = Mathf.Sin(angle) * radius;
            float y = Mathf.Cos(angle) * radius;

            pointPos = new Vector3(x, 0, y) + MaterialOptionsHolder.transform.position;

            var instance = Instantiate(MaterialCubePrefab, pointPos, Quaternion.identity, MaterialOptionsHolder.transform);
            instance.tag = "MaterialCube";
            var material = currentSelected.GetComponent<ObjectMaterialOptions>().materials[i];
            instance.GetComponent<Renderer>().material = material;
        }
    }

    private void DestroyMaterialOptions()
    {
        foreach (Transform child in MaterialOptionsHolder.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
    }

    private void ChangeMaterial(Material material)
    {
        lastSelected.GetComponent<Renderer>().material = material;
    }
}
