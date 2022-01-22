using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
     Rigidbody m_Rigidbody;
    public float m_Thrust = 10f;
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
                 m_Rigidbody.AddForce(transform.up * m_Thrust,ForceMode.Impulse);
            }
        }
        else
        {
            print("Not on ground!");
        }
        jump_pressedLastFrame = Input.GetKey("w");
        
        
        AudioSource sound = gameObject.GetComponent(typeof(AudioSource)) as AudioSource;

        bool r = Input.GetKey("d");
        bool l = Input.GetKey("a");
        
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
    

    }
    private void OnTriggerEnter(Collider other)
    { 
       print("funktioniert");
        isOnGround = true;
    }
}
