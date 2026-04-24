
using Renderite.Shared;
using Renderite.Unity;
using UnityEngine;

public class CameraPostprocessingManager : MonoBehaviour
{

    public UnityEngine.Camera Camera { get; private set; }
    public bool IsPrimary { get; private set; }
    public bool IsVR { get; private set; }


    public void Initialize(UnityEngine.Camera camera, CameraSettings settings)
    {
        Camera = camera;
        IsPrimary = settings.IsPrimary;
        IsVR = settings.IsVR;

        InitializePostProcessing();

        // For primary camera, listen to the post-processing settings and update accordingly
        if (IsPrimary)
            RenderingManager.Instance.PostProcessingUpdated += UpdatePostProcessing;
        else
        {
            UpdateAA(AntiAliasingMethod.SMAA);
        }
    }

    public void UpdatePostProcessing(bool enabled, bool motionBlur, bool screenspaceReflections)
    {
    }

    public void UpdatePostProcessing(PostProcessingConfig settings)
    {
    }

    void InitializePostProcessing()
    {
    }

    void AddPostProcessing()
    {
    }

    void AddAO()
    {
    }

    void UpdateAA(AntiAliasingMethod method)
    {
    }

    public void RemovePostProcessing()
    {
    }

    void OnDestroy()
    {
        if(IsPrimary)
            RenderingManager.Instance.PostProcessingUpdated -= UpdatePostProcessing;

        RemovePostProcessing();
    }
}
