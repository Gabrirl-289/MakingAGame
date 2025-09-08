using UnityEngine;

public class Rain : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public ParticleSystem rainParticle;
    void Start()
    {
        rainParticle.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
