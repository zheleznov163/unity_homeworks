using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetVelocity : MonoBehaviour
{

    Rigidbody _rigidbody;
    public Vector3 Velocity;


    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }


    private void Start()
    {
        _rigidbody.velocity = Velocity;
    }

}
