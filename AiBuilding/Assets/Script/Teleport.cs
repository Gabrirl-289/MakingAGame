using UnityEngine;
using Unity.Cinemachine; // Use Cinemachine namespace for virtual cameras

public class Teleport : MonoBehaviour
{
  //  public UnityEngine.Camera myCamera; // Should be UnityEngine.Camera, not your custom Camera class
    public Transform destinationPortal;
    public UnityEngine.Camera portalCamera; // Should be UnityEngine.Camera
    //public MeshRenderer portalScreen;

    private RenderTexture viewTexture;

    void Start()
    {
        if (portalCamera != null)
        {
           // viewTexture = new RenderTexture(Screen.width, Screen.height, 24);
         //   portalCamera.targetTexture = viewTexture; // This works if portalCamera is UnityEngine.Camera
         //   portalScreen.material.mainTexture = viewTexture;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && destinationPortal != null)
        {
            CharacterController controller = other.GetComponent<CharacterController>();
            if (controller != null)
            {
                controller.enabled = false;
                other.transform.position = destinationPortal.position;
               // other.transform.rotation = destinationPortal.rotation;
                controller.enabled = true;
            }
            else
            {
                other.transform.position = destinationPortal.position;
               // other.transform.rotation = destinationPortal.rotation;
            }
        }
    }

    void LateUpdate()
    {
        if (portalCamera != null && destinationPortal != null)
        {
         //   UnityEngine.Camera mainCam = myCamera;
           // Vector3 relativePos = destinationPortal.InverseTransformPoint(mainCam.transform.position);
            //portalCamera.transform.position = transform.TransformPoint(relativePos);

           // Quaternion relativeRot = Quaternion.Inverse(destinationPortal.rotation) * mainCam.transform.rotation;
            //portalCamera.transform.rotation = transform.rotation * relativeRot;
        }
    }
}
