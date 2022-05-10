using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bread : MonoBehaviour
{
    public listController list;
    public AudioSource pop;




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (list.listChosen == 1)
            {
                FindObjectOfType<LifeCount>().AddLife();

                pop = GetComponent<AudioSource>();
                pop.Play();
            }
            else if (list.listChosen == 3)
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
