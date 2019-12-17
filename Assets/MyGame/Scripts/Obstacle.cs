using UnityEngine;

public class Obstacle : MonoBehaviour
{

    [SerializeField] private float MoveSpeed = 5;
    float obstaclePosition = 15f;

    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //if obstacle's position x is < -15f it will be destroyed
        if(transform.position.x < obstaclePosition * (-1))
        {
            Destroy(gameObject);
        }

        //if obstacle's position x is < -15f it will be destroyed
        if (transform.position.x > obstaclePosition)
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = Vector2.left * MoveSpeed;
    }
}
