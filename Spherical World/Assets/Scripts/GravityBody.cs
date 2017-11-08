using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
public class GravityBody : MonoBehaviour
{
    GravityAttractor world;
    Rigidbody rigidbody;
    private void Awake()
    {
        world = GameObject.FindGameObjectWithTag("World").GetComponent<GravityAttractor>();
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.useGravity = false;
        rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
    }
    private void FixedUpdate()
    {
        world.Attract(rigidbody);
    }
}
