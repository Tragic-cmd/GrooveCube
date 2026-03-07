using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    // This is to reinforce the rRigidBody structure, rb
    public Rigidbody rb;

    [Range(500f, 8000f)]
    public float forwardForce = 6000f;
    [Range(10f, 200f)]
    public float sidewaysForce = 100f;

    void FixedUpdate()
    {
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        //Time.deltaTime makes it so that a higher framerate will not cause a higher object speed.

        if ( Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if ( Input.GetKey("a") )
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindFirstObjectByType<GameManager>().EndGame();
        }
    }
}