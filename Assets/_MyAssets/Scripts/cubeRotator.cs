using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Controllables.PhysicsBased;

public class cubeRotator : MonoBehaviour
{
    public Axis axis = Axis.xAxis; 
     private void Update()
    {
        if (axis == Axis.xAxis)
            gameObject.transform.Rotate(1, 0, 0);

        if (axis == Axis.yAxis)
            gameObject.transform.Rotate(0, 1, 0);

        if (axis == Axis.zAxis)
            gameObject.transform.Rotate(0, 0, 1);
    }
}

public enum Axis
{
    xAxis,
    yAxis,
    zAxis
}


