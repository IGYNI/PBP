using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMove : MonoBehaviour
{
    [SerializeField ]private float zOffset;
    [SerializeField] private float speed;
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)) gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + speed, gameObject.transform.position.z);
        if(Input.GetKey(KeyCode.DownArrow)) gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - speed, gameObject.transform.position.z);
        if(Input.GetKey(KeyCode.RightArrow)) gameObject.transform.position = new Vector3(gameObject.transform.position.x  + speed, gameObject.transform.position.y, gameObject.transform.position.z);
        if(Input.GetKey(KeyCode.LeftArrow)) gameObject.transform.position = new Vector3(gameObject.transform.position.x - speed, gameObject.transform.position.y, gameObject.transform.position.z);
        //Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, zOffset));
        //gameObject.transform.position = cursorPosition;

        //if(Camera.main.pixelWidth / 2 > Input.mousePosition.x) gameObject.transform.position = new Vector3(gameObject.transform.position.x - speed, gameObject.transform.position.y, gameObject.transform.position.z);
        //if(Camera.main.pixelWidth / 2 < Input.mousePosition.x) gameObject.transform.position = new Vector3(gameObject.transform.position.x + speed, gameObject.transform.position.y, gameObject.transform.position.z);
        //if(Camera.main.pixelHeight / 2 > Input.mousePosition.y) gameObject.transform.position = new Vector3(gameObject.transform.position.x , gameObject.transform.position.y- speed, gameObject.transform.position.z);
        //if(Camera.main.pixelHeight / 2 < Input.mousePosition.y) gameObject.transform.position = new Vector3(gameObject.transform.position.x , gameObject.transform.position.y+ speed, gameObject.transform.position.z);

    }


}
