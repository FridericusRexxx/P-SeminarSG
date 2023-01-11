using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SternDrei : MonoBehaviour
{
   public GameObject Stern;
    // Start is called before the first frame update
    void Start()
    {
       if (Stats.sterneEnglisch == 3)
        {
            Stern.transform.position = Stern.transform.position + new Vector3 (0,0,-1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
