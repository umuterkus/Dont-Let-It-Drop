using DG.Tweening;
using UnityEngine;

namespace DontLetItFall.Gameplay
{
    public class Stick : MonoBehaviour
    {
        [SerializeField] private Slot _currentSlot;
        private bool _isAnimating;

        private void OnMouseDown()
        {
            if (_isAnimating) return;
            _isAnimating = true;
            _currentSlot.SetEmpty();

            StickHolder.Instance.AddStick(gameObject);

            Sequence seq = DOTween.Sequence();
            seq.Append(transform.DOScale(transform.localScale * 1.3f, 0.1f).SetEase(Ease.OutBack));
            seq.Append(transform.DOScale(transform.localScale, 0.1f));
            seq.Append(transform.DOLocalMoveZ(transform.position.z - 7f, 0.3f).SetEase(Ease.InBack));
            seq.OnComplete(() =>
            {
                _isAnimating = false;
                gameObject.SetActive(false);
            });
        }

        public void SetSlot(Slot slot)
        {
            _currentSlot = slot;
        }

        private void OnDisable()
        {
            DOTween.Kill(transform);
        }
    }
}