using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Stern : MonoBehaviour
{
    public GameObject SternEins;
    // Start is called before the first frame update
    void Start()
    {
       if (Stats.sterneEnglisch >= 1)
        {
            SternEins.transform.position = SternEins.transform.position + new Vector3 (-14,0,0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
