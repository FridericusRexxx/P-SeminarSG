using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSave
{
    public void savePrefs()
    {
        PlayerPrefs.SetFloat ("BesteZeitEnglisch", Stats.bestTimeEnglisch);
        PlayerPrefs.SetInt ("SterneEnglisch", Stats.sterneEnglisch);
    }

    public void loadPrefs()
    {
        Stats.bestTimeEnglisch = PlayerPrefs.GetFloat("BesteZeitEnglisch");
        Stats.sterneEnglisch = PlayerPrefs.GetInt("SterneEnglisch");
    }
}
