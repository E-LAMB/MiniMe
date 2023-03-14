using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HopScript : MonoBehaviour
{

    public float hoptime = 20f;

    public AnimationCurve unmodified_hop;

    public Vector3 adding;
    public Vector3 starting_position;
    public Transform my_trans;

    public float speed;

    public void NewHop()
    {
        hoptime = 0f;
    }

    // Start is called before the first frame update
    void Start()
    {
        starting_position = my_trans.position;
    }

    // Update is called once per frame
    void Update()
    {
        speed = Mind.mind_hop_speed;
        adding.y = unmodified_hop.Evaluate(hoptime) * Mind.mind_hop_amount;
        hoptime += Time.deltaTime * speed;
        if (Mind.mind_hop_bool)
        {
            my_trans.position = starting_position + adding;
        }
    }
}
