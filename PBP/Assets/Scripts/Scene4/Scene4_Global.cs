using UnityEngine;

public class Scene4_Global : MonoBehaviour
{

  [SerializeField] private int Amount_OfButtons;
  [SerializeField] private Transform Luk;
  public float Progress_Speed_Fall_timer; 
  public float Global_TimeFor_Scene_timer;

  public float Buttons_timer;
  private float Buttons_timer_reaL;
  public float Global_TimeFor_Scene;
  public float SubValue;
  public float Progress_Speed_Fall;
  public float AddValue;
  public float Progress_Fall;
  public GameObject[] Buttons;

  private bool yes = false;
  private float timer = 3;

  private void OnEnable()
  {
    Buttons[Amount_OfButtons].SetActive(true);
    Amount_OfButtons++;
    Progress_Speed_Fall_timer = Progress_Speed_Fall;
  }


  public void IsPressed()
  {
    Luk.Rotate(3.5f / Amount_OfButtons, 0, 0);
  }

  public void Update()
  {
    if(yes)
    {
      if((timer -= Time.deltaTime) <= 0)
      {
        Debug.Log("ПИЗДА");
        Camera.main.GetComponent<GlobalSituation>().Global_Countdown_Laugh++;
        Camera.main.GetComponent<GlobalSituation>().AmountOfGoneStages++;
        Debug.Log(Camera.main.GetComponent<GlobalSituation>().AmountOfGoneStages);
        Camera.main.GetComponent<GlobalSituation>().Change_GameStage(0); 
        Camera.main.GetComponent<Scene4_Global>().enabled = false;
      }
    }
      Debug.Log("ПИЗДА И ТОЧКА");
      Debug.Log(Luk.rotation.x);
    if(Luk.rotation.x < -0.65)
    {
      
      Luk.GetComponent<Rigidbody>().isKinematic = false;
      yes = true;
    }
    //Для прогреса 
    if((Progress_Speed_Fall_timer -= Time.deltaTime) <= 0)
      {
        Progress_Speed_Fall_timer = Progress_Speed_Fall;
        Luk.Rotate(-SubValue, 0, 0);
      }
    

    if ((Global_TimeFor_Scene_timer -= Time.deltaTime) <= 0)
    {
      Debug.Log("ХУЙ");
      Camera.main.GetComponent<GlobalSituation>().AmountOfGoneStages++;
      Debug.Log(Camera.main.GetComponent<GlobalSituation>().AmountOfGoneStages);
      Camera.main.GetComponent<GlobalSituation>().Change_GameStage(0);  
      Camera.main.GetComponent<Scene4_Global>().enabled = false;
    }
    if((Buttons_timer_reaL -= Time.deltaTime) <= 0)
    {
      Buttons_timer_reaL = Buttons_timer;
      Buttons[Amount_OfButtons].SetActive(true);
      Amount_OfButtons++;
    }

      
  }


}
