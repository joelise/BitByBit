using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void LoadScene(string _sceneName) => SceneManager.LoadScene(_sceneName);
    public void LoadScene(Scene _scene) => LoadScene(_scene.name);
    public void LoadTitle() => LoadScene("Title");
    public void ReloadScene() => LoadScene(SceneManager.GetActiveScene().name);
    public void Quit() => Application.Quit();
}
