using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverPanel;

    private void Start()
    {
        gameOverPanel.SetActive(false);

    }
    private void OnEnable()
    {
        DeathZone.OnGameOver += HandleGameOver;
    }

    private void OnDisable()
    {
        DeathZone.OnGameOver -= HandleGameOver;
    }

    private void HandleGameOver()
    {
        gameOverPanel.SetActive(true);

    }
}
