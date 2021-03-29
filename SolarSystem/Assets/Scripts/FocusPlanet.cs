using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusPlanet : MonoBehaviour
{
    public List<GameObject> planets;
    public Vector3 offset;
    private int index = 0;
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            index = 0;
        if (Input.GetKeyDown(KeyCode.Alpha2))
            index = 1;
        if (Input.GetKeyDown(KeyCode.Alpha3))
            index = 2;
        if (Input.GetKeyDown(KeyCode.Alpha4))
            index = 3;
        if (Input.GetKeyDown(KeyCode.Alpha5))
            index = 4;
        if (Input.GetKeyDown(KeyCode.Alpha6))
            index = 5;
        if (Input.GetKeyDown(KeyCode.Alpha7))
            index = 6;
        if (Input.GetKeyDown(KeyCode.Alpha8))
            index = 7;
        if (Input.GetKeyDown(KeyCode.Alpha9))
            index = 8;

        if (planets[index] != null)
            this.transform.position = planets[index].transform.position + offset;
    }
}
