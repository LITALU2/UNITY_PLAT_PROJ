using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
            SceneManager.LoadScene(2);

        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
            LoseLife();
    }



    public void AddLife()
    {
        if (liveRemaining < 3)
        {
            //add value of live remaining
            liveRemaining++;
        }
        //add one of the hearts
        lives[liveRemaining-1].enabled = true;
        
    }
}
