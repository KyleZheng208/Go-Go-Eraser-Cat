using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movment : MonoBehaviour
{

    public Rigidbody rb;
    // Declaring a variable that is used for forces
    public float forward_force = 1000f;
    public float sideways_force = 250f;

    // Update is called once per frame
    void FixedUpdate()
    {
        // Moving the player
        rb.AddForce(0, 0, forward_force * Time.deltaTime);

        // Inputs
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb.AddForce(sideways_force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb.AddForce(-sideways_force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f && end_trigger.won == false)
        {
            FindObjectOfType<game_manager>().end_game();
            game_manager.dead = true;
        }
    }
}
