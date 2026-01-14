using UnityEngine;
using UnityEngine.Rendering;

public class CameraRenderer 
{
    ScriptableRenderContext context;

    Camera camera;

    // Main renderer function of camera.
    // A camera renders a scene instructed by context.
    public void Render (ScriptableRenderContext context, Camera camera) 
    {
        this.context = context;
        this.camera = camera;
    }
}