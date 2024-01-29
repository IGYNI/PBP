using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neo_Counter : MonoBehaviour
{
    public int Bullets_Max;
    public float timer_max;
    private int Bullets_Got;
    private float timer;
    public void CollisionDetected(Collision cilder)
    {
        Bullets_Got++;
        if(Bullets_Got >= Bullets_Max) 
        {
            Debug.Log("Смех");
            Camera.main.GetComponent<GlobalSituation>().Global_Countdown_Laugh++;
            Camera.main.GetComponent<GlobalSituation>().AmountOfGoneStages++;
            Camera.main.GetComponent<GlobalSituation>().PlayLaugh();
            Camera.main.GetComponent<GlobalSituation>().Next_GameStage();
        }
    } 

    public void Update()
    {
        if ((timer -= Time.deltaTime) >= 0)
        {
            Debug.Log("нихуя");
            Camera.main.GetComponent<GlobalSituation>().AmountOfGoneStages++;
            Camera.main.GetComponent<GlobalSituation>().Next_GameStage(); 
        }

    }
}
