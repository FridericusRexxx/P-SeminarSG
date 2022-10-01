using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KabelPlayer : MonoBehaviour
{
    public bool isInCorrectPosition = false;
    int correctPositions;

    void Start()
    {
        correctPositions = 0;
        Cursor.visible = true;
    }

    private void OnTriggerEnter(Collider other)
    { 
        if(isInCorrectPosition==true)
        {
            print("Richtige Position!");
            correctPositions++;
        }
        else
        {
            print("Nicht die richtige Position");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(isInCorrectPosition==true)
        {
            print("Has left the correct position");
            correctPositions--;
        }
        else
        {
            print("Has left a position");
        }
    }
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            print("Pressed primary button");
            float translation = Input.GetAxisRaw("Vertical");
            gameObject.transform.position = gameObject.transform.position + new Vector3(translation,0,0);
        }
    }
}
