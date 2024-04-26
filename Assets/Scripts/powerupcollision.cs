using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpCollisionScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("onTriggerEnter!!!");

        if (collision.name == "navecita(Clone)")
        {
            Debug.Log("Gane!!!");
            collision.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), 1f);
            collision.transform.localScale = new Vector3(1.5f, Random.Range(1f, 2f), 1f);
        }

        if (collision.name == "Fantasma(Clone)")
        {
            Debug.Log("Gane!!!");
            Color currentColor = collision.GetComponent<SpriteRenderer>().color;
            collision.GetComponent<SpriteRenderer>().color = new Color(currentColor.r, currentColor.g, currentColor.b, Random.Range(10, 100) / 255f);
            collision.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
        }
    }
}
