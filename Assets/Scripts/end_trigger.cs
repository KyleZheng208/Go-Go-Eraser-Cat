using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class end_trigger : MonoBehaviour
{

    void Start()
    {
        won = false;
    }

    public game_manager gameManager;
    public static bool won = false;

    void OnTriggerEnter()
    {
        if (game_manager.dead == false)
        {
            Debug.Log("win");
            won = true;
        }
    }

    void FixedUpdate()
    {

        if(won == true)
        {
            gameManager.win();
        }

        if(won == true && Input.GetKey("space"))
        {
            won = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
