using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public movment mov;
    public follow_player fc;

    // Collision Detection
    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle" && end_trigger.won  == false)
        {
            mov.enabled = false;
            fc.enabled = false;
            FindObjectOfType<game_manager>().end_game();
            game_manager.dead = true;
        }
    }
}
