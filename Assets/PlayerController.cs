using UnityEngine;


public class PlayerController : MonoBehaviour
{

    Rigidbody2D rb;

    float speed = 250.0f;

    Vector2 direction;
    Vector2 movement;
    public Transform InteractorSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (direction != Vector2.zero) // Only update when moving
        {
            InteractorSource.localPosition = direction.normalized * 0.5f; // Move InteractorSource in the movement direction
        }
    }

    private void FixedUpdate()
    {
        direction = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector2.up;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector2.down;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector2.right;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector2.left;
        }

        direction = direction.normalized;
        movement = direction * speed * Time.deltaTime;

        rb.velocity = movement;
    }
}
