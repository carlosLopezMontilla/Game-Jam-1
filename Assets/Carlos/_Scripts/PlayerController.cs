using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    public float speed;
    public Rigidbody _rb;

    [Header("Jump")]
    public bool isGrounded;
    public float jumpForce;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");

        _rb.velocity = new Vector3(h * speed, _rb.velocity.y);
    }

}
