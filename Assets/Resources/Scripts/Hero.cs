using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    
    [SerializeField] private Camera mainCamera;

    [SerializeField] private Rigidbody2D rb;

    private Vector2 movement;
    private Vector2 mouseClickPos;

    private bool mousePressed;
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * movementSpeed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        other.gameObject.GetComponent<BadBoy>().enabled = false;
    }

    public void _ResetPosition()
    {
        this.transform.position = Vector3.zero;
    }
}
