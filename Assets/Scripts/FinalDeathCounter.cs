using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalDeathCounter : MonoBehaviour
{
    public Text death_text;

    // Update is called once per frame
    void Update()
    {
        death_text.text = "Final Death Count: " + game_manager.deaths;
    }
}
