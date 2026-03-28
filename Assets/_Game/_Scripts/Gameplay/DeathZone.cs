using System;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public static event Action OnGameOver;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            OnGameOver?.Invoke();

        }

    }
}
