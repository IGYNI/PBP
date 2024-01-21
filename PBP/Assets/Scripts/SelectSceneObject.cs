using UnityEngine;

public class SelectSceneObject : MonoBehaviour
{
    enum Choices
    {
        good—hoice = 0,
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
                globalSituation.AmountOfGoneStages++;
                globalSituation.Next_GameStage();
            }
            else
            {
                globalSituation.AmountOfGoneStages++;
                globalSituation.Next_GameStage();
            }
        }
    }
    public void SetCurrentChoice(int choice)
    {
        if( choice == 0)
        {
            currentChoice = Choices.good—hoice;
            goodOutline.OutlineWidth = 2;
            badOutline.OutlineWidth = 0;
        }
        else if( choice == 1) 
        {
            currentChoice = Choices.badChoice;
            goodOutline.OutlineWidth = 0;
            badOutline.OutlineWidth = 2;
        }
    }

}
