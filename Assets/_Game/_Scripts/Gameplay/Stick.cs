using UnityEngine;

public class Stick : MonoBehaviour
{


    void OnMouseDown()
    {
        Debug.Log("týklandý");
        Destroy(gameObject);
    }

}
