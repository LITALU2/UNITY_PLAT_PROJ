using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeCount : MonoBehaviour
{
    public Image[] lives;
    public int liveRemaining;

    public void LoseLife()
    {
        
        //decrease value of live remaining
        liveRemaining--;
        //hide one of the hearts
        lives[liveRemaining].enabled = false;
        //if run out lose game
        if (liveRemaining == 0)
        {
            Debug.Log("YOU WON");
            Debug.Log("time to get out of here");

        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
            LoseLife();
    }



    public void AddLife()
    {

        //add value of live remaining
        liveRemaining++;
        //add one of the hearts
        lives[liveRemaining].enabled = true;
        
    }
}
