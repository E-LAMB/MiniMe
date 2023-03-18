using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider_Script : MonoBehaviour
{

    public int value_to_change;

    public float extracted_value;
    public float rounded_value;

    public TMPro.TextMeshProUGUI my_text;

    public UnityEngine.UI.Slider my_slider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        extracted_value = my_slider.value;
        rounded_value = Mathf.Round(extracted_value * 100f) / 100f;
        my_text.text = rounded_value.ToString();

        if (value_to_change == 1)
        {
            Mind.mind_intensity = rounded_value;
        }
        if (value_to_change == 2)
        {
            Mind.mind_threshold = rounded_value;
        }
        if (value_to_change == 3)
        {
            Mind.mind_linger = rounded_value;
        }
        if (value_to_change == 4)
        {
            Mind.mind_hop_amount = rounded_value;
        }
        if (value_to_change == 5)
        {
            Mind.mind_hop_speed = rounded_value;
        }
        if (value_to_change == 6)
        {
            Mind.mind_hop_wait = rounded_value;
        }
        if (value_to_change == 7)
        {
            Mind.boyancy_intensity = rounded_value;
        }
        if (value_to_change == 8)
        {
            Mind.chatter_intensity = rounded_value;
        }
    }
}
