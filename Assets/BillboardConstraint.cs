using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillboardConstraint : MonoBehaviour
{
    public bool X = true;
    public bool Y = true;
    public bool Z = true;

    private void LateUpdate()
    {
        Vector3 curRotation = this.transform.rotation.eulerAngles;
        if (X)
        {
            curRotation.x = 0;
        }
        if (Y)
        {
            curRotation.y = 0;
        }
        if (Z)
        {
            curRotation.z = 0;
        }
        this.transform.eulerAngles = curRotation;
    }
}
