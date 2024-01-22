using UnityEngine;

public class PresenterController : MonoBehaviour
{
    [SerializeField] Transform startPoint;
    [SerializeField] Transform endPoint;
    [SerializeField] float speed = 2f;
    private bool isMove = false;

    private float t; // для зберігання значення інтерполяції

    void Update()
    {
        if (isMove)
        {
            MovePresenter();
        }
    }

    private void MovePresenter()
    {
        t += speed * Time.deltaTime; // збільшення значення в залежності від швидкості руху

        transform.position = Vector3.Lerp(startPoint.position, endPoint.position, Mathf.PingPong(t, 1f));
    }

    private void IsMove(bool move) 
    { 
        isMove = move;
    }

    private void OnEnable()
    {
        SelectSceneObject.OnCurrentGoodChoice += IsMove;
    }
    private void OnDisable()
    {
        SelectSceneObject.OnCurrentGoodChoice -= IsMove;
    }
}
