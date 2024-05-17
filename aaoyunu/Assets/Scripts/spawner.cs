using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject objectToSpawn; 

    void Start()
    {
    }

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            SpawnObject();
        }
    }

    void SpawnObject()
    {
        if (GameManager.instance.IsGamePaused) return;
        Instantiate(objectToSpawn, transform.position, transform.rotation);
    }
}

