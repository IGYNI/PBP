using UnityEngine;

public class DestroyGameObj : MonoBehaviour
{
    [SerializeField] float secondToDestroy = 3f;

    private void Start()
    {
        Destroy(gameObject, secondToDestroy);
    }
}
