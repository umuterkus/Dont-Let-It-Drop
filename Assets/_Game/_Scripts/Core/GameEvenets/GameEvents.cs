using System;
using UnityEngine;

namespace DontLetItFall.Core
{
    public static class GameEvents
    {
        public static event Action<float> OnImpact;

        public static void TriggerImpact(float strength)
        {
            OnImpact?.Invoke(strength);
        }
    }
}
