using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class end_trigger : MonoBehaviour
{

    public game_manager gameManager;
    public static bool won = false;

    void OnTriggerEnter()
    {
        won = true;
        gameManager.win();
    }

    void Update()
    {
        if(won == true && Input.GetKey("space"))
        {
            won = false;
            try
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            catch
            {
                Debug.Log("Error");
            }
        }
    }
}
