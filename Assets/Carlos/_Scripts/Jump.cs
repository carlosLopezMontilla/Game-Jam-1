using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Jump : MonoBehaviour
{
    public Transform feetPos;
    public bool isGrounded;
    public float distanceToGround;
    public int jumpForce;
    public Rigidbody _rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(feetPos.transform.position, Vector3.down);

        isGrounded = Physics.Raycast(ray, distanceToGround, LayerMask.GetMask("Ground"));
        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            _rb.velocity = Vector3.up * jumpForce;
        }
    }
}

