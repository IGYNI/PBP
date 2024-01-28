using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public Transform bullet;
    public float speed;
    public GameObject Particle;
    private float timer = 5;
    void Update()
    {
        if ((timer -= Time.deltaTime) <= 0)
        { 
            Debug.Log("DESTORYESDSDDSD");
            gameObject.SetActive(false);
        }
        bullet.position = new Vector3(bullet.position.x + speed / 10.7F, bullet.position.y, bullet.position.z - speed);
    }

    void OnCollisionEnter(Collision collision)
    {
        Instantiate(Particle, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
    }
}
