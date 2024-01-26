using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Control_Spine : MonoBehaviour
{
    public Transform Spine;

    private Vector3 mousePos;
    private float Degree_OfSpin;
    void Update()
    {
        mousePos = Input.mousePosition;

        Spine.rotation = Quaternion.Euler((2 / (Camera.main.pixelWidth / mousePos.x) + 170) * -70 , 55 / (Camera.main.pixelWidth / mousePos.x)  + 60, Spine.rotation.z - 90 );
    }
}
