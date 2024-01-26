using UnityEngine;

public class Scene4_Global : MonoBehaviour
{

  [SerializeField] private int Amount_OfButtons;
  private float Progress_Speed_Fall_timer; 
  private float Global_TimeFor_Scene_timer;

  public float Buttons_timer;
  public float Global_TimeFor_Scene;
  public float SubValue;
  public float Progress_Speed_Fall;
  public float AddValue;
  public float Progress_Fall;
  public GameObject[] Buttons;

  public void Start()
  {
    Buttons[Amount_OfButtons].SetActive(true);
    Amount_OfButtons++;
    Progress_Speed_Fall_timer = Progress_Speed_Fall;
  }

  public void IsPressed()
  {
    Progress_Fall += AddValue / Amount_OfButtons + 1;
  }

  public void Update()
  {

    //Для прогреса 

    if((Progress_Speed_Fall_timer -= Time.deltaTime) <= 0)
      {
        Progress_Speed_Fall_timer = Progress_Speed_Fall;
        Progress_Fall -= SubValue;
      }
    
      if(Progress_Fall <= 0)
      {
      Debug.Log("Тут конец со смехом");
      }


      if ((Global_TimeFor_Scene_timer -= Time.deltaTime) <= 0)
      {
        Debug.Log("Тут конец без смеха");
      }

      if((Buttons_timer -= Time.deltaTime) <= 0)
      {
        Buttons[Amount_OfButtons].SetActive(true);
        Amount_OfButtons++;
      }

      
  }


}
