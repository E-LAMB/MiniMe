using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle_Script : MonoBehaviour
{

    public int value_to_change;

    public bool is_active;

    public UnityEngine.UI.Toggle my_toggle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        is_active = my_toggle.isOn;
        if (value_to_change == 1)
        {
            Mind.mind_hop_bool = is_active;
        }
    }
}

