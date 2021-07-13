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
        float x = 0;
        float y = 0;

        if (Input.GetKeyDown(KeyCode.D))
            x = -1;
        else if (Input.GetKeyDown(KeyCode.A))
            x = 1;

        if (Input.GetKeyDown(KeyCode.W))
            y = 1;
        else if (Input.GetKeyDown(KeyCode.S))
            y = -1;

        if (x != 0 || y != 0)
            MoveIn(x, y);
    }

    private void MoveIn(float x, float y)
    {
        transform.position += new Vector3(x, y, 0);
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
