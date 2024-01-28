using UnityEngine;
using UnityEngine.UI;

public class CountAllShoots : MonoBehaviour
{
    [SerializeField] private Text totalShootsText;
    [SerializeField] private Text totalShootsHitText;


     public int totalShootsValue;
     public int totalShootsHitValue;

    void Update()
    {
        if (totalShootsHitValue == 20f)
        {
            Camera.main.GetComponent<GlobalSituation>().AmountOfGoneStages++;
            Camera.main.GetComponent<GlobalSituation>().Change_GameStage(0); 
        }
        if ((totalShootsValue - totalShootsHitValue) == 20)
        {
            Camera.main.GetComponent<GlobalSituation>().Global_Countdown_Laugh++;
            Camera.main.GetComponent<GlobalSituation>().AmountOfGoneStages++;
            Camera.main.GetComponent<GlobalSituation>().Change_GameStage(0); 
        }

        totalShootsHitText.text = totalShootsHitValue.ToString();
        totalShootsText.text = totalShootsValue.ToString();
    }
}
