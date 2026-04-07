using DG.Tweening;
using UnityEngine;

namespace DontLetItFall.Gameplay
{
    public class StickOutline : MonoBehaviour
    {
        [SerializeField] private Outline outline;
        private Tweener _outlineTween;

        private void Start()
        {
            _outlineTween = DOTween.To(
                () => outline.OutlineColor,
                color => outline.OutlineColor = color,
                Color.green,
                2f
            )
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.InOutSine);
        }

        public void StopOutline()
        {
            _outlineTween?.Kill();
            outline.enabled = false;
        }
    }
}