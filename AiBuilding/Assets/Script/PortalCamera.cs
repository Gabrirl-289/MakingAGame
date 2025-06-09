using UnityEngine;
using System.Collections;
using UnityEngine.Rendering;
#if UNITY_RENDER_PIPELINE_UNIVERSAL
using UnityEngine.Rendering.Universal;
#endif
using RenderPipeline = UnityEngine.Rendering.RenderPipeline;
// Ensure the Portal class is defined or imported
public class Portal : MonoBehaviour
{
    // Add properties or methods as needed


}


public class PortalCamera : MonoBehaviour
{
   [SerializeField]
   private Portal[] portals = new Portal[2]; // Assuming two portals for simplicity


    [SerializeField]
    private UnityEngine.Camera portalCamera; // UnityEngine.Camera for rendering the portal view

    [SerializeField]
    private int iteractions = 7;

    private RenderTexture tempTexture1;
    private RenderTexture tempTexture2;

    private UnityEngine.Camera mainCamera;
}
