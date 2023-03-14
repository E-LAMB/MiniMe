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

    public float showtime;

    public float time_since_spoken;
    public float time_required_hop;

    public HopScript my_hopper;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time_since_spoken += Time.deltaTime;

        time_required_hop = Mind.mind_hop_wait;

        threshold = Mind.mind_threshold;
        sensitivity = Mind.mind_intensity;

        float loudness = detector.GetLoudnessFromMicClip() * sensitivity;

        if (threshold > loudness)
        {
            loudness = 0;
        } else
        {
            showtime = Mind.mind_linger;
            if (time_since_spoken >= time_required_hop)
            {
                my_hopper.NewHop();
            }
            time_since_spoken = -0.05f;
        }

        if (showtime > 0f)
        {
            showtime -= Time.deltaTime;
            should_switch = true;
        } else
        {
            should_switch = false;
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
