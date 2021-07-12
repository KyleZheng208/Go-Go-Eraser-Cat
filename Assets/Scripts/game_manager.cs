using UnityEngine;
using UnityEngine.SceneManagement;

public class game_manager : MonoBehaviour
{

    bool game_ended = false;
    public follow_player fc;
    public static bool dead = false;
    public float restart_delay = 2f;

    public GameObject complete_level_UI;

    void Start()
    {
        dead = false;
    }

    public void end_game()
    {
        if (game_ended == false)
        {
            fc.enabled = false;
            game_ended = true;
            Debug.Log("Game End");
            Invoke("restart", 1f);
        }
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void win()
    {
        complete_level_UI.SetActive(true);
    }

}
