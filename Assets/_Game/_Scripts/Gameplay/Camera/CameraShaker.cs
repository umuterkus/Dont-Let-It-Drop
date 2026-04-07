using UnityEngine;
using DontLetItFall.Core;

namespace DontLetItFall.Gameplay.Camera
{
    public class CameraShaker : MonoBehaviour
    {
        private Vector3 _originalPos;
        private float _shakeDuration = 0f;
        private float _shakeMagnitude = 0.05f;

        private void OnEnable() => GameEvents.OnImpact += Shake;
        private void OnDisable() => GameEvents.OnImpact -= Shake;

        private void Update()
        {
            if (_shakeDuration > 0)
            {
                transform.localPosition = _originalPos + Random.insideUnitSphere * _shakeMagnitude;
                _shakeDuration -= Time.deltaTime;
            }
            else if (_shakeDuration != 0)
            {
                _shakeDuration = 0f;
                transform.localPosition = _originalPos;
            }
        }

        private void Shake(float strength)
        {
            _originalPos = transform.localPosition;
            _shakeDuration = 0.2f;
            _shakeMagnitude = Mathf.Clamp(strength * 0.05f, 0.01f, 0.05f);
        }
    }
}