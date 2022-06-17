using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musicoff : MonoBehaviour
{
    public bool isOn;

    private void Start()
    {
        isOn = false;
    }
    public void OnOffSounds()
    {

            AudioListener.volume = 1f;
            isOn = true;

    }
}

