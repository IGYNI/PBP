using UnityEngine;

public class PlayerFalls : MonoBehaviour
{
    [SerializeField] private float speedOfFall;

    public GameObject player;
    public float bounceLenght;

    private void FixedUpdate()
    {
        player.transform.rotation = Quaternion.Euler(player.transform.rotation.x, speedOfFall, player.transform.rotation.z) /** Time.deltaTime*/;
    }

}
