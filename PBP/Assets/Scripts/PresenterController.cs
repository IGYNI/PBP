using UnityEngine;

public class PresenterController : MonoBehaviour
{
    [SerializeField] Transform startPoint;
    [SerializeField] Transform endPoint;
    [SerializeField] float speed = 2f;
    [SerializeField] GameObject screenTextPrefab;

    [SerializeField] bool isMove = false;

    private float t; // для зберігання значення інтерполяції
    private float lastSpawnTime;
    private float spawnRate = 3f;
    private string[] textsToScreen = { "No please!", "What do you do?", "Nooo!", "Oh no!", "I can't belive it!", "Oh, come on!", "Help me!" };

    void Update()
    {
        if (isMove)
        {
            MovePresenter();
            if (Time.time > lastSpawnTime + spawnRate)
            {
                ShowText();
                lastSpawnTime = Time.time;
            }
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

    private void ShowText()
    {
        if (screenTextPrefab)
        {
            GameObject prefabText = Instantiate(screenTextPrefab, transform.position + new Vector3(0f, 0.4f, 0f), Quaternion.identity);
            prefabText.GetComponentInChildren<TextMesh>().text = textsToScreen[Random.Range(0, textsToScreen.Length)];
        }
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
