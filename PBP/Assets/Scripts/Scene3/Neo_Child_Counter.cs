using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neo_Child_Counter : MonoBehaviour
{
    public GameObject neo;
    void OnCollisionEnter(Collision collision)
    {
        neo.GetComponent<Neo_Counter>().CollisionDetected(collision);
    }
}
