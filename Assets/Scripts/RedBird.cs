using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBird : Bird
{
    public bool _hasExplosion = false;
    [SerializeField] GameObject particlesVFX;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        Explosion();
        TriggerBirdParticlesVFX();
    }

    public void Explosion()
    {
        Destroy(gameObject);
    }

    private void TriggerBirdParticlesVFX()
    {
        GameObject particles = Instantiate(particlesVFX, transform.position, transform.rotation);
        Destroy(particles, 1f);
    }
}
