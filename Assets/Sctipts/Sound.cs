using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public bool isOn;

    void Start()
    {
        isOn = true;
    }

    public void OnOffSounds()
    {
        if (!isOn){
            AudioListener.volume = 1f;
            isOn = true;
        }else if (isOn)
        {
            AudioListener.volume = 0f;
            isOn = false;
        }
    }
}
