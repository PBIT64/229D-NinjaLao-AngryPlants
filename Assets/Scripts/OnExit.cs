using UnityEngine;
using UnityEngine.SceneManagement;

public class OnExit : MonoBehaviour
{
    public void StartGame() {
        SceneManager.LoadScene("DemoGameplay");
    }
    public void Exit() {
        Application.Quit();
    }
}
