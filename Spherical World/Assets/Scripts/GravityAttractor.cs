using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityAttractor : MonoBehaviour
{
    public float Gravity = -9.8f;
    // Rotates specified objects to the world, and applies a downwards force simulating gravity
    public void Attract(Rigidbody _body)
    {
        Vector3 targetDirection = (_body.position - transform.position).normalized;
        Vector3 bodyUp = _body.transform.up;
        _body.rotation = Quaternion.FromToRotation(bodyUp, targetDirection) * _body.rotation;
        _body.AddForce(targetDirection * Gravity);
    }
}
