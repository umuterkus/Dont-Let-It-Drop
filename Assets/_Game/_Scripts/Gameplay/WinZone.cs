using System;
using UnityEngine;

public class WinZone : MonoBehaviour
{
   
    public static event Action OnLevelCompleted;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            OnLevelCompleted?.Invoke();

        }
    }

}
