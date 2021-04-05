using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunLigth : MonoBehaviour
{
    private Light sunLigth;
    private float val;
    void Start()
    {
        val = 0;
        sunLigth = gameObject.GetComponent<Light>() as Light;
    }

    // Update is called once per frame
    void Update()
    {
        val += Time.deltaTime; 

        sunLigth.intensity = Mathf.Sin(val);
    }
}
