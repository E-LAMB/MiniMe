using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioVolumeDetector : MonoBehaviour
{

    public int sampleWindow = 64;

    public float total_loudness;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public Void Mic_To

    public float GetLoudnessFromAudioClip(int clipPosition, AudioClip clip)
    {

        int startPosition = clipPosition - sampleWindow;

        if (startPosition < 0)
        {
            return 0f;
        }

        float[] waveData = new float[sampleWindow];
        clip.GetData(waveData, startPosition);

        total_loudness = 0f;
        for (int i = 0; i < sampleWindow; i++)
        {
            total_loudness += Mathf.Abs(waveData[i]);
        }
        total_loudness = total_loudness / sampleWindow;

        return total_loudness;

    }

}
