using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    public float speed;
    public Rigidbody _rb;

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

    /*private void OnCollisionEnter(Collision collision)
    {
        if(collision.contactCount > 0)
        {
            ContactPoint contact = collision.GetContact(0);
            _rb.AddForce(contact.normal * 10, ForceMode.Impulse);
        }
    }*/
}
