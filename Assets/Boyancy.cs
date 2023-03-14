using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boyancy : MonoBehaviour
{

    public Transform self;

    public Vector3 original;

    public Vector3 new_vec;

    public AnimationCurve growing;

    public float timer;
    public float addition;

    // Start is called before the first frame update
    void Start()
    {
        original = self.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        new_vec = original;

        addition = growing.Evaluate(timer);
        addition = addition * Mind.boyancy_intensity;

        new_vec.y = original.y + addition;
        self.localScale = new_vec;
        if (timer >= 2.2f)
        {
            timer -= 2.2f;
        }
    }
}
