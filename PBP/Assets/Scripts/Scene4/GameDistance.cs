using UnityEngine;

public class GameDistance : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Transform maxPosition;
    [SerializeField] private Transform minPosition;
    [HideInInspector] public float distance; //distance between player and maxPosition
    [HideInInspector] private float playedDistance; //distance between minPosition and maxPosition

    private void Start()
    {
        playedDistance = Vector3.Distance(minPosition.position, maxPosition.position);
    }
    private void Update()
    {
        distance = Vector3.Distance(player.transform.position, maxPosition.position);

        if (distance >= playedDistance)
        {
            PauseGame();
        }
    }
    public void PauseGame()
    {
        Time.timeScale = 0f;
    }

    public  void ResumeGame()
    {
        Time.timeScale = 1f;
    }

}
