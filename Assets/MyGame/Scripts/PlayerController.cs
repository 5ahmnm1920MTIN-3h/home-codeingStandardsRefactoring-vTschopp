using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float jumpForce = 5;

    bool grounded;
    bool gameOver;

    Rigidbody2D rb;
    Animator anim;

    string jumpTrigger = "Jump";
    string deathAnimation = "SantaDeath";
    string collisionTagGround = "Ground";
    string collisionTagObstacles = "Obstacle";

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

        anim.SetTrigger(jumpTrigger);

        GameManager.instance.IncrementScore();
    }

    private bool SetGameOverTrue()
    {
        return true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == collisionTagGround)
        {
            grounded = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == collisionTagObstacles)
        {
            GameManager.instance.GameOver();
            Destroy(collision.gameObject);
            anim.Play(deathAnimation);
            gameOver = SetGameOverTrue();
        }
    }
}
