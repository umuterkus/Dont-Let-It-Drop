using DG.Tweening;
using UnityEngine;

public class Slot : MonoBehaviour
{
    public bool IsEmpty { get; private set; } = true;

    private void OnMouseDown()
    {
        if (!IsEmpty) return;

        GameObject stick = StickHolder.Instance.GetStick();
        if (stick == null) return;

        Vector3 targetPos = transform.position + Vector3.forward * -2f;
        Vector3 startPos = targetPos + Vector3.back * 5f;

        stick.transform.position = startPos;
        stick.SetActive(true);

        Stick newStick = stick.GetComponent<Stick>();
        newStick.SetSlot(this);
        IsEmpty = false;

        stick.transform.DOMove(targetPos, 0.25f).SetEase(Ease.OutQuad);
    }

    public void SetEmpty()
    {
        IsEmpty = true;
    }

    private void OnDisable()
    {
        DOTween.Kill(transform);
    }
}