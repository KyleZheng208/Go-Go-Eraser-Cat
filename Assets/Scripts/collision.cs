using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public movment mov;

    // Collision Detection
    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle" && end_trigger.won  == false)
        {
            mov.enabled = false;
            FindObjectOfType<game_manager>().end_game();
        }
    }
}
