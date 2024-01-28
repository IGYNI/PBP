using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class force : MonoBehaviour
{
    private void OnEnable() {
        gameObject.GetComponent<Rigidbody>().AddForce(new Vector3 (-80, 90, 140));
    }
    
}
