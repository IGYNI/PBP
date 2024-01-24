using UnityEngine;

public class QuickTimeEventManager : MonoBehaviour
{

    [SerializeField] private PlayerFalls _playerFalls;
    [SerializeField] private GameDistance _gameDistance;

    [SerializeField] private float livingTime;

    private KeyCode[] quickTimeKeys = {
        KeyCode.Q, KeyCode.M, KeyCode.S, KeyCode.Alpha5, KeyCode.D, KeyCode.LeftControl,
        KeyCode.E, KeyCode.J, KeyCode.Alpha3, KeyCode.G, KeyCode.H, KeyCode.Alpha7
    };
    private bool isEventActive = true;
    private float bounceAfterDivided;
  

    private void Update()
    {
        livingTime += Time.deltaTime;
        if (isEventActive && _gameDistance.distance >= bounceAfterDivided)
        {
            
            CheckForInput();
        }
    }


    private void CheckForInput()
    {

        if (livingTime <= 3)
        {
            bounceAfterDivided = _playerFalls.bounceLenght/1;
            if (Input.GetKeyDown(quickTimeKeys[0]))
            {
                _playerFalls.player.transform.position += new Vector3(0, bounceAfterDivided, 0);
            }
        }
        else if (livingTime <= 6)
        {
            bounceAfterDivided = _playerFalls.bounceLenght / 2;
            if (Input.GetKeyDown(quickTimeKeys[0]) || Input.GetKeyDown(quickTimeKeys[1]))
            {
                _playerFalls.player.transform.position += new Vector3(0, bounceAfterDivided, 0);
            }
        }
        else if (livingTime <= 9)
        {
            bounceAfterDivided = _playerFalls.bounceLenght / 3;
            if (Input.GetKeyDown(quickTimeKeys[0]) || Input.GetKeyDown(quickTimeKeys[1]) || Input.GetKeyDown(quickTimeKeys[2]))
            {
                _playerFalls.player.transform.position += new Vector3(0, bounceAfterDivided, 0);
            }
        }
        else if (livingTime <= 12)
        {
            bounceAfterDivided = _playerFalls.bounceLenght / 4;
            if (Input.GetKeyDown(quickTimeKeys[0]) || Input.GetKeyDown(quickTimeKeys[1]) || Input.GetKeyDown(quickTimeKeys[2]) || Input.GetKeyDown(quickTimeKeys[3]))
            {
                _playerFalls.player.transform.position += new Vector3(0, bounceAfterDivided, 0);
            }
        }
        else if (livingTime <= 15)
        {
            bounceAfterDivided = _playerFalls.bounceLenght / 5;
            if (Input.GetKeyDown(quickTimeKeys[0]) || Input.GetKeyDown(quickTimeKeys[1]) || Input.GetKeyDown(quickTimeKeys[2]) || Input.GetKeyDown(quickTimeKeys[3]) || Input.GetKeyDown(quickTimeKeys[4]))
            {
                _playerFalls.player.transform.position += new Vector3(0, bounceAfterDivided, 0);
            }
        }
        else if (livingTime <= 18)
        {
            bounceAfterDivided = _playerFalls.bounceLenght / 6;
            if (Input.GetKeyDown(quickTimeKeys[0]) || Input.GetKeyDown(quickTimeKeys[1]) || Input.GetKeyDown(quickTimeKeys[2]) || Input.GetKeyDown(quickTimeKeys[3]) || Input.GetKeyDown(quickTimeKeys[4]) || Input.GetKeyDown(quickTimeKeys[5]))
            {
                _playerFalls.player.transform.position += new Vector3(0, bounceAfterDivided, 0);
            }
        }
        else if (livingTime <= 21)
        {
            bounceAfterDivided = _playerFalls.bounceLenght / 7;
            if (Input.GetKeyDown(quickTimeKeys[0]) || Input.GetKeyDown(quickTimeKeys[1]) || Input.GetKeyDown(quickTimeKeys[2]) || Input.GetKeyDown(quickTimeKeys[3]) || Input.GetKeyDown(quickTimeKeys[4]) || Input.GetKeyDown(quickTimeKeys[5]) || Input.GetKeyDown(quickTimeKeys[6]))
            {
                _playerFalls.player.transform.position += new Vector3(0, bounceAfterDivided, 0) * Time.deltaTime;
            }
        }
        else if (livingTime <= 24)
        {
            bounceAfterDivided = _playerFalls.bounceLenght / 8;
            if (Input.GetKeyDown(quickTimeKeys[0]) || Input.GetKeyDown(quickTimeKeys[1]) || Input.GetKeyDown(quickTimeKeys[2]) || Input.GetKeyDown(quickTimeKeys[3]) || Input.GetKeyDown(quickTimeKeys[4]) || Input.GetKeyDown(quickTimeKeys[5]) || Input.GetKeyDown(quickTimeKeys[6]) || Input.GetKeyDown(quickTimeKeys[7]))
            {
                _playerFalls.player.transform.position += new Vector3(0, bounceAfterDivided, 0);
            }
        }
        else if (livingTime <= 27)
        {
            bounceAfterDivided = _playerFalls.bounceLenght / 9;
            if (Input.GetKeyDown(quickTimeKeys[0]) || Input.GetKeyDown(quickTimeKeys[1]) || Input.GetKeyDown(quickTimeKeys[2]) || Input.GetKeyDown(quickTimeKeys[3]) || Input.GetKeyDown(quickTimeKeys[4]) || Input.GetKeyDown(quickTimeKeys[5]) || Input.GetKeyDown(quickTimeKeys[6]) || Input.GetKeyDown(quickTimeKeys[7]) && Input.GetKeyDown(quickTimeKeys[8]))
            {
                _playerFalls.player.transform.position += new Vector3(0, bounceAfterDivided, 0);
            }
        }
        else if (livingTime <= 30)
        {
            bounceAfterDivided = _playerFalls.bounceLenght / 10;
            if (Input.GetKeyDown(quickTimeKeys[0]) || Input.GetKeyDown(quickTimeKeys[1]) || Input.GetKeyDown(quickTimeKeys[2]) || Input.GetKeyDown(quickTimeKeys[3]) || Input.GetKeyDown(quickTimeKeys[4]) || Input.GetKeyDown(quickTimeKeys[5]) || Input.GetKeyDown(quickTimeKeys[6]) || Input.GetKeyDown(quickTimeKeys[7]) || Input.GetKeyDown(quickTimeKeys[8]) || Input.GetKeyDown(quickTimeKeys[9]))
            {
                _playerFalls.player.transform.position += new Vector3(0, bounceAfterDivided, 0);
            }
        }
        else if (livingTime <= 33)
        {
            bounceAfterDivided = _playerFalls.bounceLenght / 11;
            if (Input.GetKeyDown(quickTimeKeys[0]) || Input.GetKeyDown(quickTimeKeys[1]) || Input.GetKeyDown(quickTimeKeys[2]) || Input.GetKeyDown(quickTimeKeys[3]) || Input.GetKeyDown(quickTimeKeys[4]) || Input.GetKeyDown(quickTimeKeys[5]) || Input.GetKeyDown(quickTimeKeys[6]) || Input.GetKeyDown(quickTimeKeys[7]) || Input.GetKeyDown(quickTimeKeys[8]) || Input.GetKeyDown(quickTimeKeys[9]) || Input.GetKeyDown(quickTimeKeys[10]))
            {
                _playerFalls.player.transform.position += new Vector3(0, bounceAfterDivided, 0);
            }
        }
        else if (livingTime <= 36)
        {
            bounceAfterDivided = _playerFalls.bounceLenght / 12;
            if (Input.GetKeyDown(quickTimeKeys[0]) || Input.GetKeyDown(quickTimeKeys[1]) || Input.GetKeyDown(quickTimeKeys[2]) || Input.GetKeyDown(quickTimeKeys[3]) || Input.GetKeyDown(quickTimeKeys[4]) || Input.GetKeyDown(quickTimeKeys[5]) || Input.GetKeyDown(quickTimeKeys[6]) || Input.GetKeyDown(quickTimeKeys[7]) || Input.GetKeyDown(quickTimeKeys[8]) || Input.GetKeyDown(quickTimeKeys[9]) || Input.GetKeyDown(quickTimeKeys[10]) || Input.GetKeyDown(quickTimeKeys[11]))
            {
                _playerFalls.player.transform.position += new Vector3(0, bounceAfterDivided, 0);
            }
        }
        else if(livingTime > 36)
        {
            _gameDistance.PauseGame();
            isEventActive = false;
        }
    }
   
}
