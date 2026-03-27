using System.Collections.Generic;
using UnityEngine;


public class StickHolder : MonoBehaviour
{
    public static StickHolder Instance;

    [SerializeField] private List<GameObject> _sticks = new List<GameObject>();

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    public void AddStick(GameObject stick)
    {
        _sticks.Add(stick);
    }

    public void RemoveStick(GameObject stick) 
    {
        _sticks.Remove(stick);
    }

    public GameObject GetStick()
    {
        if (_sticks.Count > 0)
        {
            GameObject stick = _sticks[0];
            _sticks.RemoveAt(0);
            return stick;
        }
        return null;
    }


}
