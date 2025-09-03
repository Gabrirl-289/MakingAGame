using UnityEngine;
using UnityEngine.Playables;

public class DoorOpener : MonoBehaviour
{
    public PlayableDirector doorOpenAnimation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            // Rotate the door 90 degrees around the Y axis
            //transform.Rotate(0, 90, 0);
            doorOpenAnimation.Play();
        }
    }
}
