using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneGamePlay : MonoBehaviour
{
    [SerializeField] private SceneAsset scene;
    public void Restart()
    {
        SceneManager.LoadScene(scene.name);
    }
}
