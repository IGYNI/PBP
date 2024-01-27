using UnityEngine;

public class KillThisOrc : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

         
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.CompareTag("Orc"))
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
}
