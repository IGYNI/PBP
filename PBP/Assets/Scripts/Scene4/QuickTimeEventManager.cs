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
    public GameObject[] Buttons;
    private bool isEventActive = true;
    private float bounceAfterDivided;
    private float AmountOfButtons;
    [SerializeField] private float timer;

    private void Update()
    {
        _playerFalls.player.transform.Rotate(0, -1*((90 / timer) * Time.deltaTime) , 0);
        livingTime += Time.deltaTime;
        //if (isEventActive && _gameDistance.distance >= bounceAfterDivided)
        //{
            
            CheckForInput();
        //}
    }


    private void CheckForInput()
    {
        
        if (livingTime <= 3)
        {
            Debug.Log("12");
            Buttons[0].SetActive(true);
            Buttons[0].transform.position = new Vector3(1, 1, 1); 
            bounceAfterDivided = 1 / AmountOfButtons;
            if (Input.GetKeyDown(quickTimeKeys[0]))
            {
                AmountOfButtons = 1;
                Buttons[0].transform.position = new Vector3(1.2f, 1.2f, 1.2f);
                _playerFalls.player.transform.Rotate(bounceAfterDivided, 0, 0);
            }
        }
        else if (livingTime <= 6)
        {
            Debug.Log("34");
            Buttons[1].SetActive(true);
            Buttons[1].transform.position = new Vector3(1, 1, 1); 
            bounceAfterDivided = _playerFalls.bounceLenght / 2;
            if (Input.GetKeyDown(quickTimeKeys[0]) || Input.GetKeyDown(quickTimeKeys[1]))
            {
                AmountOfButtons = 2;
                Buttons[1].transform.position = new Vector3(1.2f, 1.2f, 1.2f);
                _playerFalls.player.transform.Rotate(bounceAfterDivided, 0, 0);
            }
        }
        else if (livingTime <= 9)
        {
            Debug.Log("56");
            Buttons[2].SetActive(true);
            Buttons[2].transform.position = new Vector3(1, 1, 1); 
            bounceAfterDivided = _playerFalls.bounceLenght / 3;
            if (Input.GetKeyDown(quickTimeKeys[0]) || Input.GetKeyDown(quickTimeKeys[1]) || Input.GetKeyDown(quickTimeKeys[2]))
            {
                AmountOfButtons = 3;
                Buttons[2].transform.position = new Vector3(1.2f, 1.2f, 1.2f);
                _playerFalls.player.transform.Rotate(bounceAfterDivided, 0, 0);
            }
        }
        else if (livingTime <= 12)
        {
            Buttons[3].SetActive(true);
            Buttons[3].transform.position = new Vector3(1, 1, 1); 
            bounceAfterDivided = _playerFalls.bounceLenght / 4;
            if (Input.GetKeyDown(quickTimeKeys[0]) || Input.GetKeyDown(quickTimeKeys[1]) || Input.GetKeyDown(quickTimeKeys[2]) || Input.GetKeyDown(quickTimeKeys[3]))
            {
                AmountOfButtons = 4;
                Buttons[3].transform.position = new Vector3(1.2f, 1.2f, 1.2f);
                _playerFalls.player.transform.Rotate(bounceAfterDivided, 0, 0);
            }
        }
        else if (livingTime <= 15)
        {
            
            Buttons[4].SetActive(true);
            Buttons[4].transform.position = new Vector3(1, 1, 1); 
            bounceAfterDivided = _playerFalls.bounceLenght / 5;
            if (Input.GetKeyDown(quickTimeKeys[0]) || Input.GetKeyDown(quickTimeKeys[1]) || Input.GetKeyDown(quickTimeKeys[2]) || Input.GetKeyDown(quickTimeKeys[3]) || Input.GetKeyDown(quickTimeKeys[4]))
            {
                AmountOfButtons = 5;
                Buttons[4].transform.position = new Vector3(1.2f, 1.2f, 1.2f);
                _playerFalls.player.transform.Rotate(bounceAfterDivided, 0, 0);
            }
        }
        else if (livingTime <= 18)
        {
            Buttons[5].SetActive(true);
            Buttons[5].transform.position = new Vector3(1, 1, 1); 
            bounceAfterDivided = _playerFalls.bounceLenght / 6;
            if (Input.GetKeyDown(quickTimeKeys[0]) || Input.GetKeyDown(quickTimeKeys[1]) || Input.GetKeyDown(quickTimeKeys[2]) || Input.GetKeyDown(quickTimeKeys[3]) || Input.GetKeyDown(quickTimeKeys[4]) || Input.GetKeyDown(quickTimeKeys[5]))
            {
                AmountOfButtons = 6;
                Buttons[5].transform.position = new Vector3(1.2f, 1.2f, 1.2f);
                _playerFalls.player.transform.Rotate(bounceAfterDivided, 0, 0);
            }
        }
        else if (livingTime <= 21)
        {
            Buttons[6].SetActive(true);
            Buttons[6].transform.position = new Vector3(1, 1, 1); 
            bounceAfterDivided = _playerFalls.bounceLenght / 7;
            if (Input.GetKeyDown(quickTimeKeys[0]) || Input.GetKeyDown(quickTimeKeys[1]) || Input.GetKeyDown(quickTimeKeys[2]) || Input.GetKeyDown(quickTimeKeys[3]) || Input.GetKeyDown(quickTimeKeys[4]) || Input.GetKeyDown(quickTimeKeys[5]) || Input.GetKeyDown(quickTimeKeys[6]))
            {
                AmountOfButtons = 7;
                Buttons[6].transform.position = new Vector3(1.2f, 1.2f, 1.2f);
                _playerFalls.player.transform.position += new Vector3(0, bounceAfterDivided, 0) * Time.deltaTime;
            }
        }
        else if (livingTime <= 24)
        {
            Buttons[7].SetActive(true);
            Buttons[7].transform.position = new Vector3(1, 1, 1); 
            bounceAfterDivided = _playerFalls.bounceLenght / 8;
            if (Input.GetKeyDown(quickTimeKeys[0]) || Input.GetKeyDown(quickTimeKeys[1]) || Input.GetKeyDown(quickTimeKeys[2]) || Input.GetKeyDown(quickTimeKeys[3]) || Input.GetKeyDown(quickTimeKeys[4]) || Input.GetKeyDown(quickTimeKeys[5]) || Input.GetKeyDown(quickTimeKeys[6]) || Input.GetKeyDown(quickTimeKeys[7]))
            {
                AmountOfButtons = 8;
                Buttons[7].transform.position = new Vector3(1.2f, 1.2f, 1.2f);
                _playerFalls.player.transform.Rotate(bounceAfterDivided, 0, 0);
            }
        }
        else if (livingTime <= 27)
        {
            Buttons[8].SetActive(true);
            Buttons[8].transform.position = new Vector3(1, 1, 1); 
            bounceAfterDivided = _playerFalls.bounceLenght / 9;
            if (Input.GetKeyDown(quickTimeKeys[0]) || Input.GetKeyDown(quickTimeKeys[1]) || Input.GetKeyDown(quickTimeKeys[2]) || Input.GetKeyDown(quickTimeKeys[3]) || Input.GetKeyDown(quickTimeKeys[4]) || Input.GetKeyDown(quickTimeKeys[5]) || Input.GetKeyDown(quickTimeKeys[6]) || Input.GetKeyDown(quickTimeKeys[7]) && Input.GetKeyDown(quickTimeKeys[8]))
            {
                AmountOfButtons = 9;
                Buttons[8].transform.position = new Vector3(1.2f, 1.2f, 1.2f);
                _playerFalls.player.transform.Rotate(bounceAfterDivided, 0, 0);
            }
        }
        else if (livingTime <= 30)
        {
            Buttons[9].SetActive(true);
            Buttons[9].transform.position = new Vector3(1, 1, 1); 
            bounceAfterDivided = _playerFalls.bounceLenght / 10;
            if (Input.GetKeyDown(quickTimeKeys[0]) || Input.GetKeyDown(quickTimeKeys[1]) || Input.GetKeyDown(quickTimeKeys[2]) || Input.GetKeyDown(quickTimeKeys[3]) || Input.GetKeyDown(quickTimeKeys[4]) || Input.GetKeyDown(quickTimeKeys[5]) || Input.GetKeyDown(quickTimeKeys[6]) || Input.GetKeyDown(quickTimeKeys[7]) || Input.GetKeyDown(quickTimeKeys[8]) || Input.GetKeyDown(quickTimeKeys[9]))
            {
                AmountOfButtons = 10;
                Buttons[9].transform.position = new Vector3(1.2f, 1.2f, 1.2f);
                _playerFalls.player.transform.Rotate(bounceAfterDivided, 0, 0);
            }
        }
        else if (livingTime <= 33)
        {
            Buttons[10].SetActive(true);
            Buttons[10].transform.position = new Vector3(1, 1, 1); 
            bounceAfterDivided = _playerFalls.bounceLenght / 11;
            if (Input.GetKeyDown(quickTimeKeys[0]) || Input.GetKeyDown(quickTimeKeys[1]) || Input.GetKeyDown(quickTimeKeys[2]) || Input.GetKeyDown(quickTimeKeys[3]) || Input.GetKeyDown(quickTimeKeys[4]) || Input.GetKeyDown(quickTimeKeys[5]) || Input.GetKeyDown(quickTimeKeys[6]) || Input.GetKeyDown(quickTimeKeys[7]) || Input.GetKeyDown(quickTimeKeys[8]) || Input.GetKeyDown(quickTimeKeys[9]) || Input.GetKeyDown(quickTimeKeys[10]))
            {
                AmountOfButtons = 11;
                Buttons[10].transform.position = new Vector3(1.2f, 1.2f, 1.2f);
                _playerFalls.player.transform.Rotate(bounceAfterDivided, 0, 0);
            }
        }
        else if (livingTime <= 36)
        {
            Buttons[11].SetActive(true);
            Buttons[11].transform.position = new Vector3(1, 1, 1); 
            bounceAfterDivided = _playerFalls.bounceLenght / 12;
            if (Input.GetKeyDown(quickTimeKeys[0]) || Input.GetKeyDown(quickTimeKeys[1]) || Input.GetKeyDown(quickTimeKeys[2]) || Input.GetKeyDown(quickTimeKeys[3]) || Input.GetKeyDown(quickTimeKeys[4]) || Input.GetKeyDown(quickTimeKeys[5]) || Input.GetKeyDown(quickTimeKeys[6]) || Input.GetKeyDown(quickTimeKeys[7]) || Input.GetKeyDown(quickTimeKeys[8]) || Input.GetKeyDown(quickTimeKeys[9]) || Input.GetKeyDown(quickTimeKeys[10]) || Input.GetKeyDown(quickTimeKeys[11]))
            {
                AmountOfButtons = 12;
                Buttons[11].transform.position = new Vector3(1.2f, 1.2f, 1.2f);
                _playerFalls.player.transform.Rotate(bounceAfterDivided, 0, 0);
            }
        }
        else if(livingTime > 36)
        {
            _gameDistance.PauseGame();
            isEventActive = false;
        }
    }
   
}
