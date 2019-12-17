﻿using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float jumpForce = 5;

    bool grounded;
    bool gameOver;

    Rigidbody2D rb;
    Animator anim, anim2, anim3, anim4, anim5;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && !gameOver)
        {
            if (grounded == true)
            {
                Jump();
            }
        }
    }

    void Jump()
    {
        grounded = false;

        rb.velocity = Vector2.up * jumpForce;

        anim.SetTrigger("Jump");

        GameManager.instance.IncrementScore();
    }

    private bool SetGameOverTrue()
    {
        return true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            GameManager.instance.GameOver();
            Destroy(collision.gameObject);
            anim.Play("SantaDeath");
            gameOver = SetGameOverTrue();
        }
    }
}
