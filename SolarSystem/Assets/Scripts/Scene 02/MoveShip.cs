using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShip : MonoBehaviour
{
    [SerializeField] float shipSpeed;
    [SerializeField] float rotSpeed;
    private Rigidbody spaceShip;
    private Vector3 movementVec;
    private float angle;
    private Vector3 newPos;

    private bool moveTowards;
    private bool moveBackwards;
    private float rotShipY;
    private float rotShipZ;
    private float rotShipX;
    private void Start()
    {
        spaceShip = gameObject.GetComponent<Rigidbody>();
        movementVec = Vector3.zero;
        angle = transform.rotation.z;
    }
    // Update is called once per frame
    void Update()
    {
        /*
         * 
        movementVec = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * shipSpeed;
        transform.position += movementVec * Time.deltaTime;

        Vector3 lastPos = transform.position;
        Vector3 wantedPos = transform.position + movementVec * Time.deltaTime;

        float angleRot = RealAngle(lastPos, wantedPos);

        Quaternion currentRot = transform.rotation;
        Quaternion newRot = Quaternion.Euler(0, angleRot, 0);
        Quaternion finalRot = Quaternion.Slerp(currentRot, newRot, rotSpeed * Time.deltaTime);

        if (Mathf.Abs(movementVec.x) > 0.001f || Mathf.Abs(movementVec.z) > 0.001f)
            transform.rotation = finalRot;  
        */
        rotShipY -= Input.GetAxis("Horizontal") * rotSpeed;
        rotShipZ -= Input.GetAxis("Vertical") * rotSpeed;

        if(Input.GetKey(KeyCode.Q))
        {
            rotShipX -= (rotSpeed * 100) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.E))
        {
            rotShipX += (rotSpeed * 100) * Time.deltaTime;
        }

        transform.eulerAngles = new Vector3(rotShipX, rotShipY, rotShipZ);

        if(Input.GetKey(KeyCode.I))
        {
            shipSpeed += 100 * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.U))
        {
            shipSpeed -= 100 * Time.deltaTime;
        }
    }

    private void LateUpdate()
    {
        if (Input.GetKey(KeyCode.N))
        {
            spaceShip.AddForce(transform.right * (shipSpeed));
        }
        if (Input.GetKey(KeyCode.M))
        {
            spaceShip.AddForce(transform.right * -(shipSpeed));
        }
    }
    public float RealAngle(Vector3 from, Vector3 to)
    {

        Vector3 rigth = Vector3.right;
        Vector3 direction = to - from;

        float resultAngle = Vector3.Angle(rigth, direction);
        Vector3 cross = Vector3.Cross(rigth, direction);

        if(cross.y < 0)
        {
            resultAngle = 360 - resultAngle;
        }

        return resultAngle;
    }
}
