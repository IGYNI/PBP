using UnityEngine;

public class FollowCursor : MonoBehaviour
{
    [SerializeField ]private float zOffset;

    void Update()
    {
      
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, zOffset));

        gameObject.transform.position = cursorPosition;
    }
}
