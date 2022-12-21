using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameManager gm;
    private Rigidbody2D rb;
    public float jumpForce;
    public float rotationForce;
    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gm.gameIsOver == false)
        {
              if(Input.GetMouseButtonDown(0))
        {
            Jump();
        }

        }
       
        transform.eulerAngles = new Vector3(0, 0, rb.velocity.y * rotationForce);
    }

    private void Jump()
    {
        rb.velocity = Vector2.up * jumpForce;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<ScoreScript>().IncreaseTheScore();
    
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gm.GameOver();
    }
}
