using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

    public string MainScene;
    public string StartScene;

    public void GameScene()
    {

        SceneManager.LoadScene(MainScene);

    }
    public void WelcomeScene()
    {

        SceneManager.LoadScene(StartScene);

    }
}