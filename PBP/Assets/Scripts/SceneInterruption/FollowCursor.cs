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
        gameObject.transform.position = new Vector3(Input.mousePosition.x /192 - 4.5f, Input.mousePosition.y/108 - 0.85f , curse);
    }
}
