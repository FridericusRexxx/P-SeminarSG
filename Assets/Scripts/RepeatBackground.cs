using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{   
    private Vector2 startPosition;
    private float repeatPoint = -8.9f;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x <= repeatPoint)
        {
            transform.position = startPosition;
        }
    }
}
