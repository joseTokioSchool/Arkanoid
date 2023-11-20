using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Vector2 initialVelocity;
    [SerializeField] float velocityMultiplier;

    Rigidbody2D ballRb;
    bool isBallMoving;
    void Start()
    {
        ballRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isBallMoving)
        {
            Launch();
        }
    }

    private void Launch()
    {
        transform.parent = null;
        ballRb.velocity = initialVelocity;
        isBallMoving = true;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Brick"))
        {
            Destroy(collision.gameObject);
            ballRb.velocity *= velocityMultiplier;
            GameManager.Instance.BlockDestroyed();
            AudioManager.AudioInstance.BrickHitClip();
        }
        if (collision.gameObject.CompareTag("Paddle"))
        {
            AudioManager.AudioInstance.PaddleHitClip();
        }
        ReboundFix();
    }
    private void ReboundFix() // Función para que la pelota no se pille en ningún eje.
    {
        float velocityDelta = 0.5f;
        float minVelocity = 0.2f;

        if (Mathf.Abs(ballRb.velocity.x) < minVelocity)
        {
            velocityDelta = Random.value < 0.5f ? velocityDelta : -velocityDelta;
            ballRb.velocity += new Vector2(velocityDelta, 0f);
        }
        if (Mathf.Abs(ballRb.velocity.y) < minVelocity)
        {
            velocityDelta = Random.value < 0.5f ? velocityDelta : -velocityDelta;
            ballRb.velocity += new Vector2(0f, velocityDelta);
        }
    }
}
