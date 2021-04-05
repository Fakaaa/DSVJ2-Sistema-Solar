using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusPlanet : MonoBehaviour
{
    public List<GameObject> planets;
    public Vector3 offset;
    private int index = 0;
    private Vector3 auxOffset;
    private void Start()
    {
        auxOffset = offset;
    }
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            index = 0;
            offset = auxOffset;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            index = 1;
            offset = auxOffset;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        { 
            index = 2;
            offset = auxOffset;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            index = 3;
            offset = auxOffset;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            index = 4;
            offset *= 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            index = 5;
            offset *= 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            index = 6;
            offset *= 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            index = 7;
            offset *= 0.5f;
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            index = 8;
            offset = auxOffset;
        }

        if (planets[index] != null)
            this.transform.position = planets[index].transform.position + offset;
    }
}
