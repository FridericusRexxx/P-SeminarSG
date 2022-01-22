using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkriptTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w"))
        {
            print("w key is held down");
            gameObject.transform.position = gameObject.transform.position + 
        }
        if(Input.GetKey("a"))
        {
            print("a key is held down");
            gameObject.transform.position = gameObject.transform.position + new Vector3(-0.06f,0,0);
        }
        if(Input.GetKey("d"))
        {
            print("d key is held down");
            gameObject.transform.position = gameObject.transform.position + new Vector3(0.06f,0,0);
        }
        
    }
}
