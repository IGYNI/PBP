using UnityEngine;
using UnityEngine.UI;

public class CountAllShoots : MonoBehaviour
{
    [SerializeField] private Text totalShootsText;
    [SerializeField] private Text totalShootsHitText;
    public GameObject cloun;


     public int totalShootsValue;
     public int totalShootsHitValue;

    public float timer = 2;
    void Update()
    {
        if (totalShootsHitValue == 20f)
        {
            Camera.main.GetComponent<GlobalSituation>().AmountOfGoneStages++;
            Camera.main.GetComponent<Transform>().Rotate(0, 180, 0);
            Camera.main.GetComponent<GlobalSituation>().Change_GameStage(6);
            Camera.main.GetComponent<GlobalSituation>().Scenes[5].SetActive(false);
            totalShootsHitText.text = null;
            totalShootsText.text = null;

        }
        if ((totalShootsValue - totalShootsHitValue) == 20)
        {
            cloun.GetComponent<Animator>().enabled = true;
            if((timer - Time.deltaTime) <= 0)
            {
            Camera.main.GetComponent<GlobalSituation>().Global_Countdown_Laugh++;
            Camera.main.GetComponent<GlobalSituation>().PlayLaugh();
            Camera.main.GetComponent<GlobalSituation>().AmountOfGoneStages++;
            Camera.main.GetComponent<Transform>().Rotate(0, 180, 0);
            Camera.main.GetComponent<GlobalSituation>().Change_GameStage(6); 
            Camera.main.GetComponent<GlobalSituation>().Scenes[5].SetActive(false);
            }
            
        }

        totalShootsHitText.text = totalShootsHitValue.ToString();
        totalShootsText.text = totalShootsValue.ToString();
    }
}
