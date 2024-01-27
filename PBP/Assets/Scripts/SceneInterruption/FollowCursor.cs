using UnityEngine;

public class FollowCursor : MonoBehaviour
{

    void Update()
    {
        gameObject.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, -6.671533f);
    }
}
