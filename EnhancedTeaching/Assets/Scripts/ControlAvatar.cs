using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAvatar : MonoBehaviour
{
    private float move = 0.0f;
    private float turn = 0.0f;
    private float viewturn = 0.0f;
    

    public float turnSpeed = 100.0f;
    public float moveSpeed = 0.5f;

    private void Update()
    {
        transform.rotation *= Quaternion.AngleAxis(turn * turnSpeed * Time.deltaTime, Vector3.up);
        transform.rotation *= Quaternion.AngleAxis(viewturn * turnSpeed * Time.deltaTime, Vector3.right);
        transform.position += move * moveSpeed * transform.forward;
    }

    public void turnLeft()
    {
        turn = -1.0f;
    }
    public void turnRight()
    {
        turn = 1.0f;
    }
    public void ViewUp()
    {
        viewturn = -1.0f;
    }
    public void ViewDown()
    {
        viewturn = 1.0f;
    }
    public void moveForward()
    {
        move = 1.0f;
    }
    public void moveBack()
    {
        move = -1.0f;
    }
    public void stopEverything()
    {
        move = 0.0f;
        turn = 0.0f;
        viewturn = 0.0f;
    }

}
