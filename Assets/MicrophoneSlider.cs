using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicrophoneSlider : MonoBehaviour
{

    public int value_to_change;

    public float extracted_value;
    public float rounded_value;
    public int integer_value;

    public TMPro.TextMeshProUGUI my_text;

    public UnityEngine.UI.Slider my_slider;

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
        my_text.text = rounded_value.ToString();

        if (value_to_change == 1)
        {
            Mind.mic_to_use = integer_value;
        }
    }
}
