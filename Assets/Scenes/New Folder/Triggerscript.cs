using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggerscript : MonoBehaviour
{
 public string TriggerMessage = " ";
void OnTriggerEnter (Collider other)
{
    if (other.gameObject.tag == "Player")
    {
        TriggerMessage="Hello";
    }
}
 void OnTriggerExit (Collider other)
 { // damit triggerst du wenn der spieler wegeht
    if (other.gameObject.tag == "Player") 
    {
        TriggerMessage= "Goodbye" ;
         }
 }
  void OnGUI()
  {
    GUI.Label(new Rect(0, 10, 100, 100),TriggerMessage);
  }
}
