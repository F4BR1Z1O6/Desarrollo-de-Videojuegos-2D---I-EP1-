using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AparecerAlEspacio : MonoBehaviour
{
    public GameObject objectToSpawn;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            float randomX = Random.Range(-5f, 5f);
            Vector3 spawnPosition = new Vector3(randomX, 3f, 0f);

            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0f;

            Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
        }
    }
}