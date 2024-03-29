using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalSituation : MonoBehaviour
{
    
    public enum GameStage
    {
        Interruption,
        Scene1,
        Scene2,
        Scene3,
        Scene4,
        Scene5,
        Scene6

    }

    [SerializeField] private GameStage _currentGameStage;
    public int Global_Countdown_Laugh;
    public int AmountOfGoneStages;
    public GameObject[] Scenes;
    public GameObject TV_Screen;

    public GameObject Parametr;
    public Text Global_Countdown_Laugh_text;


    public void Change_GameStage (int stage)//1 - 6 сцены, 0 перебивка
    {
        //Show_Countdown_Laugh(0.0001f, 100000);
        if (stage != 0) TV_Screen.SetActive(true);

        switch(stage)
        {
            case 0:
                _currentGameStage = GameStage.Interruption;
                TV_Screen.SetActive(false);
                break;
            case 1:
                _currentGameStage = GameStage.Scene1;
                break;
            case 2:
                _currentGameStage = GameStage.Scene2;
                break;
            case 3:
                _currentGameStage = GameStage.Scene3;
                break;
            case 4:
                _currentGameStage = GameStage.Scene4;
                break;
            case 5:
                _currentGameStage = GameStage.Scene5;
                break;
            case 6:
                _currentGameStage = GameStage.Scene6;
                break;

        }

        foreach (var Scene in Scenes)
                {
                    Scene.SetActive(false);
                }
        Scenes[stage].SetActive(true);
    }

    public void Next_GameStage()
    {
        Change_GameStage(AmountOfGoneStages++);
    }

    //public void Show_Countdown_Laugh(float speed, float duration) позже доделаю либо допилю
    //{
    //    Global_Countdown_Laugh_text.text = Global_Countdown_Laugh.ToString();
    //    float Position_Canvas = 0.1038293001071872f;
    //    float Hide_Canvas = 0.9920149477609871f;
    //    while (Parametr.transform.position.y > Position_Canvas) Parametr.transform.position = new Vector3(Parametr.transform.position.x, Parametr.transform.position.y - speed, Parametr.transform.position.z);
    //    Debug.Log(Parametr.transform.position.y);
    //    float counter = 0;
    //    while (counter < duration) counter += Time.deltaTime;
    //    Debug.Log("2");
    //    while (Parametr.transform.position.y < Hide_Canvas) Parametr.transform.position = new Vector3(Parametr.transform.position.x, Parametr.transform.position.y + speed, Parametr.transform.position.z);
    //    Debug.Log("3");
    //    Debug.Log(Parametr.transform.position.y);
    //    
    //}
}
