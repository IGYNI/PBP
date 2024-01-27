using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    public GameObject Prefab_Bullet;
    public float Timer_Range;
    private float Timer_Wait;

    void Start()
    {
        Timer_Wait = Random.Range(1, Timer_Range);
    }

    void Update()
    {
        Timer_Wait -= Time.deltaTime;
        if (Timer_Wait <= 0 )
        {
            Timer_Wait = Random.Range(1, Timer_Range);
            Instantiate(Prefab_Bullet, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
        }
    }
}
