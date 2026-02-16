using UnityEngine;
using UnityEngine.InputSystem;

public class BirdScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public float flapStrength = 8f;
    public float fixedX = -2f;
    public LogicScript logic;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // Keep bird at same horizontal position
        rb.position = new Vector2(fixedX, rb.position.y);
        rb.linearVelocity = new Vector2(0, rb.linearVelocity.y);
    }

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            rb.linearVelocity = new Vector2(0, 0);
            rb.AddForce(Vector2.up * flapStrength, ForceMode2D.Impulse);
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
    }
}


