using UnityEngine;

public class Slot : MonoBehaviour
{
    public bool IsEmpty { get; private set; } = true;

    private void OnMouseDown()
    {
        if (IsEmpty)
        {
            GameObject stick = StickHolder.Instance.GetStick();
            if (stick != null)
            {
                stick.SetActive(true);
                stick.transform.position = transform.position;
                IsEmpty = false;

            }
                
        }
    }
}
