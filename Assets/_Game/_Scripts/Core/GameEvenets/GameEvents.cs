using System;
using UnityEngine;


public static class GameEvents
{
    public static event Action<float> OnImpact;

    public static void TriggerImpact(float strength)
    {
        OnImpact?.Invoke(strength);
    }
}
