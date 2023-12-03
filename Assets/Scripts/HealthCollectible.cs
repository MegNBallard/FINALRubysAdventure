using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    public ParticleSystem collectParticles;
    public AudioClip collectedClip;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            if (controller.health < controller.maxHealth)
            {
                controller.ChangeHealth(1);
                Destroy(gameObject);
            
                controller.PlaySound(collectedClip);

                if (collectParticles != null)
            {
                ParticleSystem newCollectParticles = Instantiate(collectParticles, transform.position, Quaternion.identity);
                Destroy(newCollectParticles.gameObject, 3f); // Destroy the particle system after 3 seconds
            }
            }
        }

    }
}