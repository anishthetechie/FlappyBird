using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float deadZoneX = -45f;

    void Update()
    {
        // Move pipe left every frame
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        // Destroy pipe after it leaves screen
        if (transform.position.x < deadZoneX)
        {
            Destroy(gameObject);
        }
    }
}

