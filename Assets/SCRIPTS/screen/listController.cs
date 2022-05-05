using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class listController : MonoBehaviour
{

    int listChosen = 0;

    public GameObject tx1;
    public GameObject tx2;
    public GameObject tx3;

    // Start is called before the first frame update
    void Start()
    {
        suffelList();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void suffelList()
    {
        listChosen = Random.Range(1, 4);
        switch (listChosen)
        {
            case 1:

                tx1.gameObject.SetActive(true);
                tx2.gameObject.SetActive(false);
                tx3.gameObject.SetActive(false);
                
                break;

            case 2:
                tx1.gameObject.SetActive(false);
                tx2.gameObject.SetActive(true);
                tx3.gameObject.SetActive(false);
                break;

            case 3:
                tx1.gameObject.SetActive(false);
                tx2.gameObject.SetActive(false);
                tx3.gameObject.SetActive(true);

                
                break;
        }
    }
}
