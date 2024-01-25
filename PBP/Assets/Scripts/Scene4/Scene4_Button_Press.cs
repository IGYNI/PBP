using UnityEngine;

public class Scene4_Button_Press : MonoBehaviour
{
  public string Letter;
  
  public void Update()
    {
      if(Input.GetKey(Letter))
      {
        Debug.Log("нажал");
      }

    }

}
