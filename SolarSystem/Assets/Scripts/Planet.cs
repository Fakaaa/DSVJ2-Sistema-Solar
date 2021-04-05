using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    public struct PlanetData
    {
        public float radius;
        public float rotSpeed;
        public float traslationSpeed;
        public float scale;

        public Material mat;
    }
    [SerializeField] PlanetData planetDat;

    [SerializeField] float inRadius;
    [SerializeField] float inScale;
    [SerializeField] float inRotSpeed;
    [SerializeField] float inTransSpeed;
    [SerializeField] Material inMat;

    void Start()
    {
        planetDat.radius = inRadius;
        planetDat.scale = inScale;
        planetDat.rotSpeed = inRotSpeed;
        planetDat.traslationSpeed = inTransSpeed;
    }

    void Update()
    {
    }
}
