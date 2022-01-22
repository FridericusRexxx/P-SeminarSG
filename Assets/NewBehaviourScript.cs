using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Vector3 jump;
    bool jump_pressedLastFrame;
    bool isOnGround;
    // Start is called before the first frame update
    void Start()
    {
        jump = new Vector3(0,0,0);
        jump_pressedLastFrame = false;
        isOnGround = true;
    }   

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("right")){
                print("rArrow is held down");
                gameObject.transform.position = gameObject.transform.position + new Vector3(0.05f,0,0); 
            }
            if(Input.GetKey("left")){
                print("lArrow is held down");
                gameObject.transform.position = gameObject.transform.position + new Vector3(-0.05f,0,0); 
            }
        if(isOnGround == true)
        {
            if(!jump_pressedLastFrame && Input.GetKey("up"))
            {
                isOnGround = false;
                jump = new Vector3(0,1.3f,0);
            }
            gameObject.transform.position = gameObject.transform.position + jump;
        }
        else
        {
            print("Not on ground!");
        }
        
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
    

    }
    private void OnTriggerEnter(Collider other)
    {
        isOnGround = true;
    }
}
