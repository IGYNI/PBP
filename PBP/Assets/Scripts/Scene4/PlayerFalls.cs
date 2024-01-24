using UnityEngine;

public class PlayerFalls : MonoBehaviour
{
    

    [SerializeField] private float lengthOfFall;
    [SerializeField] private float speedOfFall;

    public GameObject player;
    public float bounceLenght;

    private void FixedUpdate()
    {
        player.transform.position -= new Vector3(0, speedOfFall, 0) * Time.deltaTime;
    }

}
