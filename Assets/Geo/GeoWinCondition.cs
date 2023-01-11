using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GeoWinCondition : MonoBehaviour
{
    public GameObject winText;
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume = 1.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private float waiting = 2.0f;
    void Update()
    {
        UIDropSlot[] slots = GetComponentsInChildren<UIDropSlot>();
        foreach(UIDropSlot slot in slots)
            if(!slot.iscorrect)
                return;
        winText.SetActive(true);
        audioSource.PlayOneShot(clip, volume);
        waiting -= Time.deltaTime;
        if(waiting <= 0)
            LevelLoader.returnToMainMenue();
    }
}