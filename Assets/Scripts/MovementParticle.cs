using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementParticle : MonoBehaviour
{

    [SerializeField]
    ParticleSystem _movementParticles;

    [Range(0, 10)]
    [SerializeField]
    int _dustParticleTime;

    [Range(0f, 0.2f)]
    [SerializeField]
    float _dustFormationPeriod;

    [SerializeField]
    Rigidbody2D rb;

    float counter;

    private void FixedUpdate()
    {
        counter += Time.deltaTime;

        if (Mathf.Abs(rb.velocity.x) > _dustParticleTime)
        {
            if (counter > _dustFormationPeriod)
            {
                _movementParticles.Play();
                counter = 0;
            }

        }
    }
}
