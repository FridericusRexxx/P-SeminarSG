using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishJumpnrun : MonoBehaviour
{
    public GameObject winText;
    private float waiting = 2.0f;
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume = 1.0f;

   IEnumerator  OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            winText.SetActive(true);
            audioSource.PlayOneShot(clip, volume);
            yield return new WaitForSeconds(2);
            SceneManager.LoadScene("Test Load");

        }
    }
}
