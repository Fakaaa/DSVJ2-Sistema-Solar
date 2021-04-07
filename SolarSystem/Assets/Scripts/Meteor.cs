using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    public bool crash;
    public void MoveMeteor(float speed, Vector3 target)
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }

    public void SetMeteorVariety(Vector3 scale)
    {
        transform.localScale = scale;
    }

    public void OnCollisionEnter(Collision collision)
    {
        crash = true;
    }
}
