using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchWithAudio : MonoBehaviour
{

    public bool should_switch;
    
    public AudioVolumeDetector detector;

    public float threshold = 0.1f;
    public float sensitivity = 100;

    public GameObject image_one;
    public GameObject image_two;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float loudness = detector.GetLoudnessFromMicClip() * sensitivity;

        if (threshold > loudness)
        {
            loudness = 0;
            should_switch = false;
        } else
        {
            should_switch = true;
        }

        if (should_switch)
        {
            image_one.SetActive(false);
            image_two.SetActive(true);
        } else
        {
            image_one.SetActive(true);
            image_two.SetActive(false);
        }
    }
}
