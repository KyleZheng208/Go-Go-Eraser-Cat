using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class change_text : MonoBehaviour
{
    public Transform player;
    public Text score_text; 

    // Update is called once per frame
    void Update()
    {
        score_text.text = player.position.z.ToString("0");
    }
}
