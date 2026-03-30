using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverPanel;

    [SerializeField] private GameObject _onLevelCompletedPanel;

    [SerializeField] private Button _restartButton;

    [SerializeField] private Button _nextLevelButton;
    private void Start()
    {
        _gameOverPanel.SetActive(false);
        _onLevelCompletedPanel.SetActive(false);
    }
    private void OnEnable()
    {
        GameManager.OnStateChange += HandleStateChange;

    }

    private void OnDisable()
    {
        GameManager.OnStateChange -= HandleStateChange;

    }

    private void HandleStateChange(GameManager.GameState state)
    {
        switch (state)
        {
            case GameManager.GameState.Win:
                _onLevelCompletedPanel.SetActive(true);
                break;
            case GameManager.GameState.Lose:
                _gameOverPanel.SetActive(true);
                break;
            case GameManager.GameState.Playing:
                _onLevelCompletedPanel.SetActive(false);
                _gameOverPanel.SetActive(false);
                break;

        }
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene(0);
        
    }

    


}
