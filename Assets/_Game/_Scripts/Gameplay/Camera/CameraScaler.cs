using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraScaler : MonoBehaviour
{
    [Header("Resulution Settings")]
    public Vector2 targetResolution = new Vector2(1080, 1920);

    [SerializeField] private Camera cam;
    private float targetAspect;
    private float initialFov;

    void Start()
    {
        targetAspect = targetResolution.x / targetResolution.y;
        initialFov = cam.fieldOfView;
        AdjustCameraFOV();
    }

    void AdjustCameraFOV()
    {
        float currentAspect = (float)Screen.width / (float)Screen.height;
        if (currentAspect < targetAspect)
        {
            float differenceInSize = targetAspect / currentAspect;
            cam.fieldOfView = 2f * Mathf.Atan(Mathf.Tan(initialFov * Mathf.Deg2Rad * 0.5f) * differenceInSize) * Mathf.Rad2Deg;
        }
        else
        {
            cam.fieldOfView = initialFov;
        }
    }
}