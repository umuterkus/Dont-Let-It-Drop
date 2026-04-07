using System.Collections.Generic;
using UnityEngine;

namespace DontLetItFall.ScriptableObjects.LevelData
{
    [CreateAssetMenu]
    public class LevelDataSO : ScriptableObject
    {
        public List<GameObject> activeSlots;
    }
}
