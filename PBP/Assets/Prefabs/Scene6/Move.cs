using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    private void Update() 
    {
        gameObject.transform.position = new Vector3(Input.mousePosition.x / 20 - 62, gameObject.transform.position.y, gameObject.transform.position.z);    
    }
}
