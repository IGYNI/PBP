using UnityEngine;
using UnityEngine.UI;

public class CountAllShoots : MonoBehaviour
{
    [SerializeField] private Text totalShootsText;
    [SerializeField] private Text totalShootsHitText;

    [HideInInspector] public int totalShootsValue;
    [HideInInspector] public int totalShootsHitValue;

    private void Update()
    {
        totalShootsHitText.text = totalShootsHitValue.ToString();
        totalShootsText.text = totalShootsValue.ToString();
    }
}
