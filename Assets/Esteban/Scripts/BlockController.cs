using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    private float horMovement;
    private float verMovement;

    private bool insideTopTrigger;
    private bool insideBottomTrigger;
    private bool insideLeftTrigger;
    private bool insideRightTrigger;

    private void Start()
    {
        insideTopTrigger = false;
        insideBottomTrigger = false;
        insideLeftTrigger = false;
        insideRightTrigger = false;
    }

    private void Update()
    {
        MovementInput();
        RotationInput();
    }

    private void MovementInput()
    {
        horMovement = 0;
        verMovement = 0;

        if (Input.GetKey(KeyCode.D))
            horMovement = 1;
        else if (Input.GetKey(KeyCode.A))
            horMovement = -1;

        if (Input.GetKey(KeyCode.W))
            verMovement = 1;
        else if (Input.GetKey(KeyCode.S))
            verMovement = -1;

        CheckMovementConstraints();

        if (horMovement != 0 || verMovement != 0)
            Move();

        if (Input.GetKey(KeyCode.Space))
        {
            this.GetComponent<BlockController>().enabled = false;
        }
    }

    private void CheckMovementConstraints()
    {
        if (verMovement > 0 && insideTopTrigger)
            verMovement = 0;
        if (verMovement < 0 && insideBottomTrigger)
            verMovement = 0;
        if (horMovement < 0 && insideLeftTrigger)
            horMovement = 0;
        if (horMovement > 0 && insideRightTrigger)
            horMovement = 0;
    }

    private void Move()
    {
        float movSpeed = 5;
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("LimitTrigger"))
        {
            print("ASDSADSAASDDAS");
            if (other.GetComponent<LimitTrigger>().isTopPlatform)
                insideTopTrigger = true;
            if (other.GetComponent<LimitTrigger>().isBottomPlatform)
                insideBottomTrigger = true;
            if (other.GetComponent<LimitTrigger>().isLeftPlatform)
                insideLeftTrigger = true;
            if (other.GetComponent<LimitTrigger>().isRightPlatform)
                insideRightTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("LimitTrigger"))
        {
            if (other.GetComponent<LimitTrigger>().isTopPlatform)
                insideTopTrigger = false;
            if (other.GetComponent<LimitTrigger>().isBottomPlatform)
                insideBottomTrigger = false;
            if (other.GetComponent<LimitTrigger>().isLeftPlatform)
                insideLeftTrigger = false;
            if (other.GetComponent<LimitTrigger>().isRightPlatform)
                insideRightTrigger = false;
        }
    }
}