using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bang : MonoBehaviour
{
    public float Power;
    public float Radius;
    public ParticleSystem BangEffect;

    public void Explode()
    {
        Collider[] overlapsColliders = Physics.OverlapSphere(transform.position, Radius);

        foreach (Collider collider in overlapsColliders)
        {
            Rigidbody rigidbody = collider.attachedRigidbody;
            if (rigidbody) 
                rigidbody.AddExplosionForce(Power, transform.position, Radius);
        }
        Instantiate(BangEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

}
