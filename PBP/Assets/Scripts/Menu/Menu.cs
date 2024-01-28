using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] private Animation _anium;
    [SerializeField] private GameObject CanvasMenu;
    public void start() 
    {
        _anium.Play("CameraMoveMenu");
        CanvasMenu.SetActive(false);
        gameObject.GetComponent<GlobalSituation>().enabled =  true;
        gameObject.gameObject.GetComponent<Menu>().enabled =  true;
    }
    public void settings()
    {

    }

    public void exit()
    {

        Application.Quit();
    }

    void Update()
    {
        
    }
}
