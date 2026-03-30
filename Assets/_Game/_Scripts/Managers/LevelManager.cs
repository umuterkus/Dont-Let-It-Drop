using System;
using System.Collections.Generic;
using UnityEngine;
using static GameManager;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> _levels;
    private int _currentLevelIndex = 0;
    public static LevelManager Instance;
    
    

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }
    private void Start()
    {
        LoadLevel(0);
    }
    public void LoadLevel(int levelIndex)
    {
        if (levelIndex < 0 || levelIndex >= _levels.Count)
        {
            Debug.LogError("Invalid level index: " + levelIndex);
            return;
        }

        foreach (var level in _levels)
        {
            level.SetActive(false);
        }

        _levels[levelIndex].SetActive(true);
        _currentLevelIndex = levelIndex;
    }

    public void LoadNextLevel()
    {
        LoadLevel(_currentLevelIndex + 1);
        GameManager.Instance.ChangeState(GameManager.GameState.Playing);
        StickHolder.Instance.ResetStickHolder();
    }

}
