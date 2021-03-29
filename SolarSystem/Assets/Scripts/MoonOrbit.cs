using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonOrbit : MonoBehaviour
{
    public float speed = 0.5f;
    public float radius = 105;
    public float angle = 0;
    public GameObject earth;

    void Update()
    {
        Vector3 v3 = earth.transform.position;
        angle += speed * Time.deltaTime;

        v3.x = radius * Mathf.Cos(angle);
        v3.z = radius * Mathf.Sin(angle);

        transform.localPosition = v3;
    }
}
