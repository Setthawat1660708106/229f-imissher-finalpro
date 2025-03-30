using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button startButton;
    public Button highscoreButton;
    public Button quitButton;

    void Start()
    {
        startButton.onClick.AddListener(StartGame);
        highscoreButton.onClick.AddListener(OpenHighscore);
        quitButton.onClick.AddListener(QuitGame);
    }

    void StartGame()
    {
        SceneManager.LoadScene("SampleScene"); // เปลี่ยน "GameScene" เป็นชื่อฉากเกมของคุณ
    }

    void OpenHighscore()
    {
        Debug.Log("Highscore Menu Opened"); // สามารถเปลี่ยนให้เปิดหน้า UI ของ Highscore ได้
    }

    void QuitGame()
    {
        Debug.Log("Game Quit");
        Application.Quit();
    }
}
