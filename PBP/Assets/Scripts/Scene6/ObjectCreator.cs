using UnityEngine;

public class ObjectCreator : MonoBehaviour
{
    [SerializeField] private CountAllShoots _shoot;
    [SerializeField] private GameObject objectToCreate;
    [SerializeField] private Transform createPosition; //Position when our ball spawn and fly to needed direction
    [SerializeField] private float speed;
    [SerializeField] private float throwForce;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            CreateAndMoveObject();
        }
    }

    private void CreateAndMoveObject()
    {
        _shoot.totalShootsValue++;
        GameObject newObject = Instantiate(objectToCreate, createPosition.position, transform.rotation);

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            Vector3 direction = hit.point - transform.position;
            Vector3 normalizedDirection = direction.normalized;
            newObject.GetComponent<Rigidbody>().velocity = normalizedDirection * (speed + throwForce);
        }
    }
}
