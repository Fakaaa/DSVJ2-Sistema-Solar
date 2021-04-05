using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public float speed = 0.5f;
    public float rotSpeed = 20.5f;
    public float radius = 105;
    public float angle = 0;
    public string direction;

    public TrailRenderer tail;

    void Start()
    {
        tail.enabled = true;
    }

    void Update()
    {
        Vector3 v3 = Vector3.zero;
        angle += speed * Time.deltaTime;

        v3.x = radius * Mathf.Cos(angle);
        v3.z = radius * Mathf.Sin(angle);

        transform.position = v3;

        switch (direction)
        {
            case "X":
                transform.Rotate(Vector3.right * Time.deltaTime * rotSpeed);
                break;
            case "Y":
                transform.Rotate(Vector3.up * Time.deltaTime * rotSpeed);
                break;
            case "Z":
                transform.Rotate(Vector3.forward * Time.deltaTime * rotSpeed); 
                break;
        }
    }
}
