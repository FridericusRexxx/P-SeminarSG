using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
     Rigidbody m_Rigidbody;
    public float m_Thrust = 10f;
    public float speed = 1;
    bool isOnGround;
    bool jump_pressedLastFrame;
    // Start is called before the first frame update
    void Start()
    {
         m_Rigidbody = GetComponent<Rigidbody>();
        isOnGround = true;
        jump_pressedLastFrame = false;
    }  

    private void UpdateMovement()
    {

        if(Input.GetKey("d")){
                print("D is held down");
                gameObject.transform.position = gameObject.transform.position + new Vector3(speed *Time.deltaTime,0,0); 
            }
            if(Input.GetKey("a")){
                print("A is held down");
                gameObject.transform.position = gameObject.transform.position + new Vector3(-speed *Time.deltaTime,0,0); 
            }
        if(isOnGround == true)
        {
            if(!jump_pressedLastFrame && Input.GetKey("w"))
            {
                //isOnGround = false;
                m_Rigidbody.AddForce(new Vector3(0,1,0) * m_Thrust, ForceMode.Impulse);
            }
        }
        else
        {
            //print("Not on ground!");
        }
        jump_pressedLastFrame = Input.GetKey("w");
    }

    private void UpdateSound()
    {
        AudioSource sound = gameObject.GetComponent(typeof(AudioSource)) as AudioSource;

        bool right = Input.GetKey("d");
        bool left = Input.GetKey("a");
        bool movement = (right || left) && !(right && left);

        if(movement && isOnGround) 
        {
            if(!sound.isPlaying)
                sound.Play();
        }
        else
        {
            if(sound.isPlaying)
                sound.Stop();
        }
    }

    // Update is called once per frame
    void Update()
    {
        UpdateMovement();
        UpdateSound();
    }
    private void OnTriggerEnter(Collider other)
    { 
       print("enter");
        isOnGround = true;
    }

    
    private void OnTriggerExit(Collider other)
    { 
       print("exit");
        isOnGround = false;
    }
}
