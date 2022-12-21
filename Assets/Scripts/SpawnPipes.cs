using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    public GameObject pipePrefab;
    private float startDelay = 1;
    private float repeatRate = 1.5f;
    private float min = -0.8f;
    private float max = 3;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("InstantiatePipes", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void InstantiatePipes()
    {
        if(FindObjectOfType<GameManager>().gameIsOver == false)
        {
        Instantiate(pipePrefab, (Vector2)transform.position + RandomVector(), pipePrefab.transform.rotation);
        }
    }

    private Vector2 RandomVector()
    {
        Vector2 spawnPosition = Vector2.up * Random.Range(min, max);
        return spawnPosition;
    }
}
