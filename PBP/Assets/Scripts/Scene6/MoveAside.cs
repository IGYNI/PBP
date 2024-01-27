using UnityEngine;

public class MoveAside : MonoBehaviour
{
    [SerializeField] private Transform leftPos;
    [SerializeField] private Transform rightPos;

    [SerializeField] private GameObject basket;

    [SerializeField] private float speed;
    private bool isReverse;


    private void Update()
    {
        if (basket.transform.position.x >= rightPos.position.x)
        {
            isReverse = true;
        }
        else if (basket.transform.position.x <= leftPos.position.x)
        {
            isReverse = false;
        }

        MoveBasket();
    }

    private void MoveBasket()
    {
        if (isReverse)
        {
            basket.transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime;
        }
        else if(!isReverse)
        {
            basket.transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
        }
    }
}
