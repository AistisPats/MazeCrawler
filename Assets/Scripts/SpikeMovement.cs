using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeMovement : MonoBehaviour
{
    public Vector2 direction = Vector2.up;
    public Rigidbody2D rb;
    public float movementSpeed = 5f;
    private float multiplier = 1f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = direction * multiplier*movementSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (multiplier > 0f)
        {
            multiplier = -1f;
        }
        else multiplier = 1f;
    }
}
