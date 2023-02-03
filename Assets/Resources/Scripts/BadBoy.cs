using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadBoy : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 1f;
    private Transform heroTransform;

    private Vector3 movementDirection;

    private void Start()
    {
        heroTransform = GameObject.Find("Hero").transform;
    }

    private void Update()
    {
        Movement();
    }
    
    private void Movement()
    {
        transform.position = Vector2.MoveTowards(transform.position, heroTransform.position, -movementSpeed * Time.deltaTime);
    }
}
