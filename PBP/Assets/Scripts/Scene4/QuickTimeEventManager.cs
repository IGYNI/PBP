using System.Collections;
using UnityEngine;

public class QuickTimeEventManager : MonoBehaviour
{

    [SerializeField] private PlayerFalls _playerFalls;
    [SerializeField] private float eventDuration;

    private KeyCode[] quickTimeKeys = {
        KeyCode.Q, KeyCode.M, KeyCode.S, KeyCode.Alpha5, KeyCode.D, KeyCode.LeftControl,
        KeyCode.E, KeyCode.J, KeyCode.Alpha3, KeyCode.G, KeyCode.H, KeyCode.Alpha7
    };
    

    private int currentIndex = 0;  // Текущий индекс кнопки, которую нужно нажать
    private bool isEventActive = false;  

    

    private void Start()
    {
        StartCoroutine(StartQuickTimeEvent());
        Debug.Log(quickTimeKeys[currentIndex].ToString());
    }

    private void Update()
    {
        if (isEventActive)
        {
            CheckForInput();
        }
    }

    private IEnumerator StartQuickTimeEvent()
    {
        yield return new WaitForSeconds(eventDuration);
        isEventActive = true;
    }

    private void CheckForInput()
    {
        if (currentIndex < quickTimeKeys.Length)
        {
            KeyCode requiredKey = quickTimeKeys[currentIndex];


            if (Input.GetKeyDown(requiredKey)) // Проверка, была ли нажата нужная кнопка
            {
                currentIndex++;
                if (currentIndex < quickTimeKeys.Length)
                {
                    Debug.Log(quickTimeKeys[currentIndex].ToString());
                }

                _playerFalls.player.transform.position += new Vector3(0, _playerFalls.bounceLenght, 0);
            }
            else if (Input.anyKeyDown)
            {
                currentIndex = 0;
                Debug.Log("Wrong key! Resetting...");
            }
        }
        else
        {
            Debug.Log("QuickTime event completed!");
            PauseGame();
            isEventActive = false;
        }
    }
    private void PauseGame()
    {
        Time.timeScale = 0f;
    }

    private void ResumeGame()
    {
        Time.timeScale = 1f;
    }
}
