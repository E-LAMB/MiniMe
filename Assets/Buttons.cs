using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{

    void Start()
    {
        if (!Mind.has_found_mic)
        {
            Mind.has_found_mic = true;
            Mind.mic_to_use = 0;
        }
    }

    void Update()
    {
        if (Mind.maximum_mics < Mind.mic_to_use)
        {
            Mind.mic_to_use = Mind.maximum_mics;
        }
        Mind.maximum_mics = Microphone.devices.Length - 1;
    }

    public void butt_quit()
    {
        Debug.Log("Program was quit");
        Application.Quit();
    }

    public void butt_reload()
    {
        Debug.Log("Program was reloaded");
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

}
