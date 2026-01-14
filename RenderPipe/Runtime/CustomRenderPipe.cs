using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class CustomRenderPipe : RenderPipeline
{
    // When rendering pipeline creates, create an instance of camera renderer.
    CameraRenderer renderer =  new CameraRenderer();

    protected override void Render(ScriptableRenderContext context, Camera[] cameras)
    {
        
    }

    // Main entry point of rendering pipeline.
    // for each camera, render the scene using the provided context.
    protected override void Render(ScriptableRenderContext context, List<Camera> cameras)
    {
        for (int i = 0; i < cameras.Count; i++)
        {
            renderer.Render(context, cameras[i]);
        }
    }
}
