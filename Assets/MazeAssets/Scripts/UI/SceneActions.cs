using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneActions : MonoBehaviour
{
    [SerializeField] private string _firstLevelSceneName;
    [SerializeField] private string _startMenuSceneName;

    public void StartGame()
    {
        SceneManager.LoadScene(_firstLevelSceneName);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(_startMenuSceneName);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
