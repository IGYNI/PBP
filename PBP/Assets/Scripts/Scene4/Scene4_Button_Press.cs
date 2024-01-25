using UnityEngine;

public class Scene4_Button_Press : MonoBehaviour
{
  public string Letter;
  
  public void Update()
    {
      if(Input.GetKey(Letter))
      {
        Camera.main.GetComponent<Scene4_Global>().IsPressed();
      }

    }

}
