/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc_Behaviour : MonoBehaviour
{

    [SerializeField]
    private enum Orc_State
    {
        Orc_Show,
        Orc_Stable,
        Orc_Out,
        Orc_Hide
    }

    //[SerializeField] private float Pos_Move_Timer;
    [SerializeField] private float Pos_Move_Speed;
    [SerializeField] private float Try_to_show;
    [SerializeField] private int Chance_OfTry;
    [SerializeField] private Orc_State orc_state;//�������( 


    private float Pos_Start;

    public float Pos_Show;


    private void Start()
    {
        Pos_Start = gameObject.transform.position.z;
    }

    private void Update()
    {
        Debug.Log(Try_to_show);
        if ((Try_to_show -= Time.deltaTime) <= 0)
        {
            if (Random.Range(0, 100) <= Chance_OfTry)
            {
                orc_state = Orc_State.Orc_Show;
            }
        }

        if (orc_state == Orc_State.Orc_Show && Pos_Show > gameObject.transform.position.z) 
                gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z - Pos_Move_Speed);
        else if (orc_state == Orc_State.Orc_Hide && Pos_Start < gameObject.transform.position.z)
                gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z + Pos_Move_Speed);
        else if (Pos_Show < gameObject.transform.position.z)
            orc_state = Orc_State.Orc_Stable;
        else if (Pos_Start > gameObject.transform.position.z)
            orc_state = Orc_State.Orc_Out;



    }







}*/