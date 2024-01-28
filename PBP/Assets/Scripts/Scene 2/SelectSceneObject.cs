using System;
using UnityEngine;

public class SelectSceneObject : MonoBehaviour
{
    public static event Action<bool> OnCurrentGoodChoice;
    enum Choices
    {
        goodchoice = 0,
        badChoice = 1
    }
    public Outline goodOutline;
    public Outline badOutline;

    private GlobalSituation globalSituation;
    [SerializeField]private Choices currentChoice;

    private void Start()
    {
        globalSituation = FindObjectOfType<GlobalSituation>();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (currentChoice == 0)
            {
                globalSituation.Global_Countdown_Laugh++;
                
            }
            //Camera.main.GetComponent<GlobalSituation>().Next_GameStage();
        }
    }
    public void SetCurrentChoice(int choice)
    {
        if( choice == 0)
        {
            currentChoice = Choices.goodchoice;
            goodOutline.OutlineWidth = 2;
            badOutline.OutlineWidth = 0;
            if (OnCurrentGoodChoice != null)
            {
                OnCurrentGoodChoice.Invoke(true);
            }
            
        }
        else if( choice == 1) 
        {
            currentChoice = Choices.badChoice;
            goodOutline.OutlineWidth = 0;
            badOutline.OutlineWidth = 2;
            if (OnCurrentGoodChoice != null)
            {
                OnCurrentGoodChoice.Invoke(false);
            }
        }
    }
}