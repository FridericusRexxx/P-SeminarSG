using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GeoWinCondition : MonoBehaviour
{
    public GameObject winText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UIDropSlot[] slots = GetComponentsInChildren<UIDropSlot>();
        foreach(UIDropSlot slot in slots)
            if(!slot.iscorrect)
                return;
        winText.SetActive(true);
    }
}
