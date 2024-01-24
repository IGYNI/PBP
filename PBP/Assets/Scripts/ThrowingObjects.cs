using System.Collections;
using UnityEngine;

public class ThrowingObjects : MonoBehaviour
{
    public GameObject[] objectsToThrow;
    public GameObject spawnPosition;
    public GameObject ScreenCamera;
    public GameObject well;

    private Vector3 startPositionCamera;
    private Quaternion startRotationCamera;
    private Vector3 endPositionCamera = new Vector3(48f, 20.72f, 17.66f);
    private Quaternion endRotationCamera = Quaternion.Euler(57.9f, -86.25f, 90f);

    private int currentIndex = 0;

    private void Start()
    {
        startPositionCamera = ScreenCamera.transform.position;
        startRotationCamera = ScreenCamera.transform.rotation;
        
        ScreenCamera.transform.SetPositionAndRotation(endPositionCamera, endRotationCamera);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SpawnCurrentObject();
        }
    }

    private void SpawnCurrentObject()
    {
        if (currentIndex < objectsToThrow.Length)
        {
            GameObject obj = Instantiate(objectsToThrow[currentIndex], spawnPosition.transform.position, Quaternion.identity);
            obj.GetComponent<Rigidbody>().AddForce(new Vector3 (-100, 0, -100));
            currentIndex++;
        }
        else
        {
            StartCoroutine(MoveCameraToWell());
        }
    }

    private IEnumerator MoveCameraToWell()
    {
        float elapsedTime = 0f;
        float moveTime = 1f; // час, протягом якого камера повинна рухатися

        while (elapsedTime < moveTime)
        {
            ScreenCamera.transform.position = Vector3.Lerp(endPositionCamera, well.transform.position, elapsedTime / moveTime);

            elapsedTime += Time.deltaTime;
            yield return null;
        }
        Invoke("ResetCameraPosition", 1f);
    }

    private void ResetCameraPosition()
    {
        ScreenCamera.transform.position = startPositionCamera;
        ScreenCamera.transform.rotation = startRotationCamera;
    }
}
