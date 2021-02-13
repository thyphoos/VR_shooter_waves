using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class follow : MonoBehaviour
{
    public Transform player;
    public float movementSpeed = 5f;
    private Rigidbody rb;
    private Vector3 movement;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg;
        rb.rotation =Quaternion.Euler(0,angle,0);
        Vector3 normalizeDirection = direction;
        normalizeDirection.Normalize();
        movement = direction.magnitude > 0.1f ? normalizeDirection : Vector3.zero;
        
    }

    private void FixedUpdate()
    {
        movePlayer(movement);
    }

    void movePlayer(Vector3 direction)
    {
        rb.MovePosition(transform.position + (direction * movementSpeed));
    }
}
