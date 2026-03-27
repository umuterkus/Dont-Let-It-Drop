using UnityEngine;

public class Stick : MonoBehaviour
{
  
    void OnMouseDown()
    { 
        StickHolder.Instance.AddStick(gameObject);
        gameObject.SetActive(false);
    }

}
