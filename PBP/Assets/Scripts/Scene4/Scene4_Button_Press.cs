using UnityEngine;

public class Scene4_Button_Press : MonoBehaviour
{
    public KeyCode Letter;

    private void Update()
    {
        
        if (Input.GetKeyUp(Letter))
        {
            Camera.main.GetComponent<Scene4_Global>().IsPressed();
            Debug.Log(Letter);
        }
    }

}
