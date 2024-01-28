using System.Runtime.InteropServices;
using UnityEngine;

public class TeleportCursor : MonoBehaviour
{
    [DllImport("user32.dll")]
    static extern bool SetCursorPos(int X, int Y);
    public Vector3 holder;

    private void Start() {
        holder = gameObject.transform.position;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Labyrinth"))
        {
            gameObject.transform.position = holder;
        }
        else
        {
            Camera.main.GetComponent<GlobalSituation>().Next_GameStage();
        }
    }

}
