using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameResulter : MonoBehaviour
{
    public bool GameEnded { get; private set; } = false;
    private void Update()
    {
        if (Keyboard.current.spaceKey.isPressed & GameEnded == true)
        {
            SceneManager.LoadScene("DemoLevel");
        }
    }

    public void EndGame (bool isWin)
    {
        if (GameEnded) { return; }
        gameObject.SetActive(true);
        TextMeshProUGUI ResultLabel = transform.Find("ResultLabel").GetComponent<TextMeshProUGUI>();
        ResultLabel.text = isWin ? "Victory" : "Defeat";
        GameEnded = true;
    }
}
