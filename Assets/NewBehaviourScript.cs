using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
     Rigidbody m_Rigidbody;
    public float m_Thrust = 1f;
    bool isOnGround;
    bool jump_pressedLastFrame;
    // Start is called before the first frame update
    void Start()
    {
         m_Rigidbody = GetComponent<Rigidbody>();
        isOnGround = true;
        jump_pressedLastFrame = false;
    }   

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("d")){
                print("D is held down");
                gameObject.transform.position = gameObject.transform.position + new Vector3(0.05f,0,0); 
            }
            if(Input.GetKey("a")){
                print("A is held down");
                gameObject.transform.position = gameObject.transform.position + new Vector3(-0.05f,0,0); 
            }
        if(isOnGround == true)
        {
            if(!jump_pressedLastFrame && Input.GetKey("w"))
            {
                isOnGround = false;
<<<<<<< HEAD
                 m_Rigidbody.AddForce(transform.up * m_Thrust,ForceMode.Impulse);
=======
                jump = new Vector3(0,1.3f,0);
>>>>>>> c978c04f629ba1a36f29d30b5fd4e44687a680a3
            }
        }
        else
        {
            print("Not on ground!");
        }
<<<<<<< HEAD
        jump_pressedLastFrame = Input.GetKey("w");
=======
        
        if(jump.y > 0)
            jump.y -= 0.1f;
        else
            jump.y = 0.0f;
        jump_pressedLastFrame = Input.GetKey("up");
        
        AudioSource sound = gameObject.GetComponent(typeof(AudioSource)) as AudioSource;

        bool r = Input.GetKey("right");
        bool l = Input.GetKey("left");
        
        if((r || l) && !(r && l)) 
        {
            if(!sound.isPlaying)
                sound.Play();
        }
        else
        {
            if(sound.isPlaying)
                sound.Stop();
        }
    

>>>>>>> c978c04f629ba1a36f29d30b5fd4e44687a680a3
    }
    private void OnTriggerEnter(Collider other)
    { 
       print("funktioniert");
        isOnGround = true;
    }
}
