using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleFromAudioClip : MonoBehaviour
{

    public AudioSource source;

    public Vector3 minscale;
    public Vector3 maxscale;
    
    public AudioVolumeDetector detector;

    public float threshold = 0.1f;
    public float sensitivity = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float loudness = detector.GetLoudnessFromAudioClip(source.timeSamples, source.clip) * sensitivity;

        if (threshold > loudness)
        {
            loudness = 0;
        }

        transform.localScale = Vector3.Lerp(minscale, maxscale, loudness);
    }
}
