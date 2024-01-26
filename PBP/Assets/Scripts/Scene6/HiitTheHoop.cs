using UnityEngine;

public class HiitTheHoop : MonoBehaviour
{
    [SerializeField] private CountAllShoots _shoot;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            _shoot.totalShootsHitValue++;
            Destroy(other.gameObject);
        }
    }
}
