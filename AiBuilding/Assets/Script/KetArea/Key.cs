using UnityEngine;
public class Key : MonoBehaviour
{
    [SerializeField] private AudioSource keySound;
    [SerializeField] private AudioSource keyAudio;
    public bool isCollected = false;
    public GameObject superket;
    public bool keyStop = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && keyStop == false)
        {
            isCollected = true;
            keySound.Play();
            keyAudio.Play();
            // Here you can add code to add the key to the player's inventory
            // For example: other.GetComponent<PlayerInventory>().AddKey();
            Destroy(superket, 0.5f); // Delay destruction to allow sound to play
            keyStop = true;
        }
    }
}
