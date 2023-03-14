using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleFromMicrophone : MonoBehaviour
{

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
        float loudness = detector.GetLoudnessFromMicClip() * sensitivity;

        if (threshold > loudness)
        {
            loudness = 0;
        }

        transform.localScale = Vector3.Lerp(minscale, maxscale, loudness);
    }
}