using UnityEngine;

public class FollowCursor : MonoBehaviour
{

    public float curse;
    public float cursee;
    
    void Start() 
    {
        curse =  gameObject.transform.position.z - 0.15f;
    }
    void Update()
    {
        gameObject.transform.position = new Vector3(Input.mousePosition.x /1000 - 1 , Input.mousePosition.y/1000 - 0.25f, curse);
    }
}
