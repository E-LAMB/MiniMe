using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chatter : MonoBehaviour
{

    public float chatter_movement;
    public Transform chatterer;

    public Vector3 original;

    public Vector3 new_position;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        original = chatterer.position;
    }

    // Update is called once per frame
    void Update()
    {

        chatter_movement = Mind.chatter_intensity;
        speed = chatter_movement / 5;

        new_position.x = Random.Range(original.x - chatter_movement, original.x + chatter_movement);
        new_position.y = Random.Range(original.y - chatter_movement, original.y + chatter_movement);

        if (Mind.is_speaking)
        {
            chatterer.position = Vector3.MoveTowards(chatterer.position, new_position, speed * Time.deltaTime);
        } else
        {
            chatterer.position = original;
        }
        
    }
}
