using System;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum GameState { Playing, Win, Lose }
    public GameState CurrentState { get; private set; }

    public static GameManager Instance;

    public static Action<GameState> OnStateChange;

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
        CurrentState = GameState.Playing;
    }

  
    public void ChangeState(GameState newState)
    {
        CurrentState = newState;
        OnStateChange?.Invoke(CurrentState);
    }

}
