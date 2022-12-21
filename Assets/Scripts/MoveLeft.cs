using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(FindObjectOfType<GameManager>().gameIsOver == false)
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);
        }
        
        if(transform.position.x < -11)
        {
            Destroy(gameObject);
        }
    }
}
