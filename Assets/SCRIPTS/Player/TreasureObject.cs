using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class TreasureObject : MonoBehaviour
{
    private void Reset()
    {
        GetComponent<BoxCollider2D>().isTrigger = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("treasure triggered");
            FindObjectOfType<LifeCount>().AddLife();
        }
    }
}
