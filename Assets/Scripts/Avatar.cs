using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar : MonoBehaviour
{
    public ParticleSystem shape, trail, burst;
    public float deathCountdown = -1f;

    private Player player;

    private void Awake()
    {
        player = transform.root.GetComponent<Player>();
    }

    [System.Obsolete]
    private void Update()
    {
        if(deathCountdown >= 0f)
        {
            deathCountdown -= Time.deltaTime;
            if(deathCountdown <= 0f)
            {
                deathCountdown = -1f;
                shape.enableEmission = true;
                trail.enableEmission = true;
                player.Die();
            }
        }
    }

    [System.Obsolete]
    private void OnTriggerEnter(Collider other)
    {
        if(deathCountdown < 0f)
        {
            shape.enableEmission = false;
            trail.enableEmission = false;
            burst.Emit(burst.maxParticles);
            deathCountdown = burst.startLifetime;
        }
    }
}
