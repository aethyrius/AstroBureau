using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed = 5f;
    private float move;

    public bool canMove = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Movement
        move = Input.GetAxis("Horizontal");

        if (canMove)
        {
            rb.velocity = new Vector2(move * speed, rb.velocity.y);
        } else
        {
            float smoothedX = Mathf.Lerp(rb.velocity.x, 0f, Time.deltaTime * 4);
            rb.velocity = new Vector2(smoothedX, rb.velocity.y);
        }
    }
}