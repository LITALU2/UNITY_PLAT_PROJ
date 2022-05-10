using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadLevel : MonoBehaviour
{
   public void LoadLevel(int levelnum)
    {
        SceneManager.LoadScene(levelnum);

    }
}
