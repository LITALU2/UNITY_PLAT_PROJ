using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class corn : MonoBehaviour
{
    public listController list;

    public AudioSource pop;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (list.listChosen == 2)
            {
                FindObjectOfType<LifeCount>().AddLife();

                pop = GetComponent<AudioSource>();
                pop.Play();
            }
            else
            {
                FindObjectOfType<LifeCount>().LoseLife();
            }
        }

    }
}
