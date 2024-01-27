using System.Collections;
using UnityEngine;

public class DestryYourself : MonoBehaviour
{
    [SerializeField] private float timeBtwDestroy;

    private void Start()
    {
        StartCoroutine(TimerBtwDestroy());
    }

    private IEnumerator TimerBtwDestroy()
    {
        yield return new WaitForSeconds(timeBtwDestroy);
        Destroy(gameObject);
    }
}
