using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicrophoneSlider : MonoBehaviour
{

    public int value_to_change;

    public float extracted_value;
    public float rounded_value;
    public int integer_value;

    public UnityEngine.UI.Slider my_slider;

    public string mic_message;
    public TMPro.TextMeshProUGUI my_title;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        my_slider.maxValue = Mind.maximum_mics;

        extracted_value = my_slider.value;
        rounded_value = Mathf.Round(extracted_value);
        integer_value = Mathf.RoundToInt(rounded_value);

        int pres_1 = integer_value += 1;
        int pres_2 = Mind.maximum_mics += 1;

        mic_message = "Microphone   (" + pres_1.ToString() + "/" + pres_2.ToString() + ")";
        my_title.text = mic_message;

        if (value_to_change == 1)
        {
            integer_value -= 1;
            Mind.mic_to_use = integer_value;
        }
    }
}
