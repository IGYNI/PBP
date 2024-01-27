using System.Collections;
using UnityEngine;

public class OrcDestryYourself : MonoBehaviour
{
    [SerializeField] private float minTimeBtwDestroy;
    [SerializeField] private float maxTimeBtwDestroy;

    private void Start()
    {
        StartCoroutine(TimerBtwDestroy(Random.Range(minTimeBtwDestroy, maxTimeBtwDestroy)));
    }

    private IEnumerator TimerBtwDestroy(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}
