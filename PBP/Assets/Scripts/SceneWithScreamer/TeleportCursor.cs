using System.Runtime.InteropServices;
using UnityEngine;

public class TeleportCursor : MonoBehaviour
{
    [DllImport("user32.dll")]
    static extern bool SetCursorPos(int X, int Y);
    public int xPos = 30;
    public int yPos = 1000;



    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Labyrinth"))
        {
            SetCursorPos(xPos, yPos);
        }
        else
        {
            Debug.Log("Victory");
        }
    }

}
