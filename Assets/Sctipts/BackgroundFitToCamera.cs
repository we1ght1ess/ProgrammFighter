using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundFitToCamera : MonoBehaviour
{
   private void Start()
    {
        ResizeBackground();
    }

    private void ResizeBackground()
    {
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
           
            Camera camera = Camera.main;
            float cameraHeight = 2f * camera.orthographicSize;
            float cameraWidth = cameraHeight * camera.aspect;
          
            float textureHeight = renderer.bounds.size.y;
            float textureWidth = renderer.bounds.size.x;
            float textureAspectRatio = textureWidth / textureHeight;

            if (textureAspectRatio >= camera.aspect)
            {
                float newHeight = cameraHeight;
                float newWidth = textureWidth / textureHeight * newHeight;
                renderer.sharedMaterial.mainTextureScale = new Vector2(newWidth, newHeight);
            }
            else
            {
                float newWidth = cameraWidth;
                float newHeight = textureHeight / textureWidth * newWidth;
                renderer.sharedMaterial.mainTextureScale = new Vector2(newWidth, newHeight);
            }
        }
    }
}
