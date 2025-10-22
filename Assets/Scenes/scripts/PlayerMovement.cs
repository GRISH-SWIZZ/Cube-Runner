using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    void FixedUpdate()
    {
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d")) // If the player is pressing the "d" key
        {
            // Add a force to the right
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a")) // If the player is pressing the "a" key
        {
            // Add a force to the left
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
