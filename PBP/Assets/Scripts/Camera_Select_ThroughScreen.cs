using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Select_ThroughScreen : MonoBehaviour
{

    enum CurentSelect
    {
        Pill_One,
        Pill_Two
    }

    public Outline Pill_One;
    public Outline Pill_Two;

    private Camera _camera;
    private Vector3 _mousePos;

    [SerializeField] private CurentSelect _curentSelect; 
    public GlobalSituation Global;
    private SelectSceneObject _selectSceneObject;

    void Start()
    {
        _camera = Camera.main; // Мейн камера это _camera
        _selectSceneObject = FindObjectOfType<SelectSceneObject>();
    }

    void Update()
    {
        _mousePos = Input.mousePosition; // Позиция мышки
        if(_camera.pixelWidth / 2 > _mousePos.x) // Если позиция мышки по координате x левее от центра экрана 
        {
            _curentSelect = CurentSelect.Pill_One; // Выбраная пилюля один
            Pill_One.OutlineWidth = 2; // Выделение пилюли
            Pill_Two.OutlineWidth = 0; // Отвыделение пилюли
            _selectSceneObject.SetCurrentChoice(0);
        }

        if(_camera.pixelWidth / 2 < _mousePos.x)// Если позиция мышки по координате x правее от центра экрана 
        {
            _curentSelect = CurentSelect.Pill_Two;// Выбраная пилюля два
            Pill_One.OutlineWidth = 0; // Выделение пилюли
            Pill_Two.OutlineWidth = 2; // Отвыделение пилюли
            _selectSceneObject.SetCurrentChoice(1);
        }

        if(Input.GetMouseButtonDown(0))
        {
            if(_curentSelect == CurentSelect.Pill_One)
            {
                Global.Global_Countdown_Laugh++;
                Global.AmountOfGoneStages++;
                Global.Change_GameStage(0); 
            }
            else
            {
               Global.AmountOfGoneStages++;
               Global.Change_GameStage(0);  
            }
        }



    }
}
