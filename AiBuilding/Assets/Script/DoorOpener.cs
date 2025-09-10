using UnityEngine;
using UnityEngine.Playables;

public class DoorOpener : MonoBehaviour
{
    public PlayableDirector doorOpenAnimation;
    public Transform attackPoint;
    public float attackRange = 1.5f;
    public LayerMask playerLayer;
    public Key Key;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Collider[] hitPlayer = Physics.OverlapSphere(attackPoint.position, attackRange, playerLayer);
        if (Key.isCollected == true)
        {
            foreach (Collider player in hitPlayer)
            {
                doorOpenAnimation.Play();
                break;
            }
            // Rotate the door 90 degrees around the Y axis
            //transform.Rotate(0, 90, 0);
        }
    }


    void OnDrawGizmosSelected()
    {
        if (attackPoint == null) return;
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}