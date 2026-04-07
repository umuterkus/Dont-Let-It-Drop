using UnityEngine;




public class FallingItem : MonoBehaviour
{
    private Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision col)
    {
        float impact = col.relativeVelocity.magnitude;
        if (impact < 2f) return;

        // Ufak yukari kuvvet ver
        float bounceForce = Mathf.Clamp(impact * 0.3f, 0f, 1.5f);
        _rb.AddForce(Vector3.up * bounceForce, ForceMode.Impulse);

        float strength = Mathf.Clamp(impact * 0.05f, 0.1f, 0.3f);
        GameEvents.TriggerImpact(strength);
    }
}
