using System;
using UnityEngine;
using DontLetItFall.Managers;

namespace DontLetItFall.Gameplay
{
    public class DeathZone : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Item"))
            {
                if (GameManager.Instance.CurrentState != GameManager.GameState.Playing) return;
                GameManager.Instance.ChangeState(GameManager.GameState.Lose);
            }
        }
    }
}
