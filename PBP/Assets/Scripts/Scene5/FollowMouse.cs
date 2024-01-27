using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    public float objectHeight = 0f;

    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            Vector3 targetPosition = hit.point + Vector3.up * objectHeight;

            transform.position = targetPosition;
        }
    }
}
