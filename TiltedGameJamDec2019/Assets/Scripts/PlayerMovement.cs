using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Public movement properties
    [SerializeField] float speed;
    [SerializeField] float acceleration;

    // Attached components
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
        Debug.Log("velocity = " + rb.velocity);
    }
}
