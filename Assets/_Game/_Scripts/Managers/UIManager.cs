using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverPanel;

    [SerializeField] private GameObject _onLevelCompletedPanel;

    [SerializeField] private Button _restartButton;
    private void Start()
    {
        _gameOverPanel.SetActive(false);
        _onLevelCompletedPanel.SetActive(false);
    }
    private void OnEnable()
    {
        DeathZone.OnGameOver += HandleGameOver;
        WinZone.OnLevelCompleted += HandleLevelCompleted;
    }

    private void OnDisable()
    {
        DeathZone.OnGameOver -= HandleGameOver;
        WinZone.OnLevelCompleted -= HandleLevelCompleted;

    }

    private void HandleGameOver()
    {
        _gameOverPanel.SetActive(true);

    }

    private void HandleLevelCompleted()
    {
        _onLevelCompletedPanel.SetActive(true);
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene(0);
        
    }


}
