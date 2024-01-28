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
    private Vector3 endPositionCamera = new Vector3(30.10f, 5f, 14);
    private Quaternion endRotationCamera = Quaternion.Euler(f, -265.852f, 90f);
    private Rigidbody cameraRigitbody;
    private int currentIndex = 0;
    [SerializeField] private float timer;
    [SerializeField] private float timerr;
    public bool yes = false;

    private void Start()
    {
        startPositionCamera = ScreenCamera.transform.position;
        startRotationCamera = ScreenCamera.transform.rotation;
        
        cameraRigitbody = ScreenCamera.AddComponent<Rigidbody>();
        cameraRigitbody.useGravity = true;
        cameraRigitbody.isKinematic = true;

        ScreenCamera.transform.position = endPositionCamera;
        ScreenCamera.transform.rotation = endRotationCamera;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SpawnCurrentObject();
        }
        if((timer -= Time.deltaTime) <= 0) 
        {
            
            Camera.main.GetComponent<GlobalSituation>().AmountOfGoneStages++;
            Camera.main.GetComponent<GlobalSituation>().Change_GameStage(0); 
        }
        if(yes)
        {
            if((timerr -= Time.deltaTime) <= 0) 
            {
                Camera.main.GetComponent<GlobalSituation>().Global_Countdown_Laugh++;
                Camera.main.GetComponent<GlobalSituation>().AmountOfGoneStages++;
                Camera.main.GetComponent<GlobalSituation>().Change_GameStage(0); 
            }
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
            cameraRigitbody.isKinematic = false;
            cameraRigitbody.AddForce(new Vector3(-300, 0, -50));
            Invoke("ResetCameraPosition", 2f);
            yes = true;
            //StartCoroutine(MoveCameraToWell());
        }
    }

    //private IEnumerator MoveCameraToWell()
    //{
    //    float elapsedTime = 0f;
    //    float moveTime = 1f; // ���, �������� ����� ������ ������� ��������

    //    while (elapsedTime < moveTime)
    //    {
    //        ScreenCamera.transform.position = Vector3.Lerp(endPositionCamera, well.transform.position, elapsedTime / moveTime);

    //        elapsedTime += Time.deltaTime;
    //        yield return null;
    //    }
    //    Invoke("ResetCameraPosition", 1f);
    //}

    private void ResetCameraPosition()
    {
        ScreenCamera.transform.position = startPositionCamera;
        ScreenCamera.transform.rotation = startRotationCamera;
        cameraRigitbody.isKinematic = true;
    }
}
