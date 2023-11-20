using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float moveSpeed;

    float bounds = 8.32f;
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");

        Vector2 playerPosition = transform.position;
        playerPosition.x = Mathf.Clamp(playerPosition.x + moveInput * moveSpeed * Time.deltaTime, -bounds, bounds);
        transform.position = playerPosition;
    }
}
