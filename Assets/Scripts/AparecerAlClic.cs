using System.Collections;
using System.Collections.Generic; 
using UnityEngine;

public class AparecerAlClic : MonoBehaviour
{
    public GameObject objectToSpawn; 

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0f;

            Instantiate(objectToSpawn, mousePosition, Quaternion.identity);
        }
    } 
}
