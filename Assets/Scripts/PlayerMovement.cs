using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{   
    public float speed = 9f;
    private Rigidbody2D rb;
    private Vector2 moveVector;
    public GameObject bullet;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {

    }

    void Update()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        moveVector.y = Input.GetAxis("Vertical");
        moveVector = moveVector.normalized;
        rb.velocity = moveVector * speed;

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Нажал");
            Instantiate(bullet, transform.position, Quaternion.identity);
        }
    }
}
