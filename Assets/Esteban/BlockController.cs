using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    private void Update()
    {
        MovementInput();
        RotationInput();
    }

    private void MovementInput()
    {
        float horMovement = 0;
        float verMovement = 0;

        if (Input.GetKey(KeyCode.D))
            horMovement = -1;
        else if (Input.GetKey(KeyCode.A))
            horMovement = 1;

        if (Input.GetKey(KeyCode.W))
            verMovement = 1;
        else if (Input.GetKey(KeyCode.S))
            verMovement = -1;

        if (horMovement != 0 || verMovement != 0)
            Move(horMovement, verMovement);
    }

    private void Move(float horMovement, float verMovement)
    {
        float movSpeed = 10;
        transform.position += new Vector3(horMovement * movSpeed * Time.deltaTime,
            verMovement * movSpeed * Time.deltaTime, 0);
    }

    private void RotationInput()
    {
        float rot = 0;

        if (Input.GetKeyDown(KeyCode.Q))
            rot = -90;
        else if (Input.GetKeyDown(KeyCode.E))
            rot = 90;

        if (rot != 0)
            RotateIn(rot);
    }

    private void RotateIn(float rot)
    {
        transform.Rotate(0, 0, rot);
    }
}