using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    void Start()
    {
        hasAddedDeath = false;
    }
    public movment mov;
    private bool hasAddedDeath = false;
    public follow_player fc;

    // Collision Detection
    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle" && end_trigger.won  == false)
        {
            if(hasAddedDeath == false)
            {
                game_manager.deaths++;
                hasAddedDeath = true;
            }
            mov.enabled = false;
            fc.enabled = false;
            FindObjectOfType<game_manager>().end_game();
            game_manager.dead = true;
        }
    }
}
