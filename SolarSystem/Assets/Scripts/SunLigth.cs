using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunLigth : MonoBehaviour
{
    const float minVal = 0.2f;
    const float maxVal = 1.0f;

    private bool decrease;
    private Light sunLigth;
    private float val;
    void Start()
    {
        val = minVal;
        decrease = false;
        sunLigth = gameObject.GetComponent<Light>() as Light;
    }

    // Update is called once per frame
    void Update()
    {
        if(!decrease)
             val += Random.Range(minVal, maxVal) * Time.deltaTime;
        else
            val -= Random.Range(minVal, maxVal) * Time.deltaTime;

        if (val >= maxVal)
            decrease = true;
        if(val <= minVal)
            decrease = false;

        Debug.Log("Value: " + val);
        sunLigth.intensity = Mathf.Sin(val);
    }
}
