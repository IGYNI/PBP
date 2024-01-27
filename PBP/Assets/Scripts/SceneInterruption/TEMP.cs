using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEMP : MonoBehaviour
{
    void OnEnable() 
    {
    Camera.main.GetComponent<GlobalSituation>().Next_GameStage();    
    }
}
