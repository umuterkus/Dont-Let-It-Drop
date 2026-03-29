using System;
using UnityEngine;

public class WinZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            if (GameManager.Instance.CurrentState != GameManager.GameState.Playing) return;
            GameManager.Instance.ChangeState(GameManager.GameState.Win);
        }
    }

}
