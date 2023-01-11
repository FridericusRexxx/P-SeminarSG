using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSystem : MonoBehaviour
{
    
    public static int sterne;
    float targetTime = 60.0f;
    public static float bestTime;
    // Start is called before the first frame update
    void Start()
    {
        bestTime = Stats.bestTimeEnglisch;
    }

    // Update is called once per frame
    void Update()
    {
        targetTime -= Time.deltaTime;
        UIDropSlot[] slots = GetComponentsInChildren<UIDropSlot>();
        foreach(UIDropSlot slot in slots)
            if(!slot.iscorrect)
                return;
                targetTime += Time.deltaTime;
    if (targetTime >= bestTime)
            {
                bestTime = targetTime;
            }   
            if (bestTime >= 50.0f)
                {
                    sterne = 3;
                }
            if (bestTime < 50.0f & bestTime > 40.0f)
                {
                    sterne = 2;
                }
            if (bestTime < 40.0f) 
                {
                    sterne = 1;
                }
     Stats.bestTimeEnglisch = bestTime;
     Stats.sterneEnglisch = sterne;
     print(bestTime);
    }
}
