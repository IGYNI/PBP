using System.Runtime.InteropServices;
using UnityEngine;

public class TeleportCursor : MonoBehaviour
{
    [DllImport("user32.dll")]
    static extern bool SetCursorPos(int X, int Y);
    public int xPos;
    public int yPos;


    private void Start() 
    {
        xPos = (int) Input.mousePosition.x;
        yPos = (int) Input.mousePosition.y;
    }
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
