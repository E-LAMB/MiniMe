using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teaching : MonoBehaviour
{

    public int unwanted_items = 0;
    public int required_items = 10;

    public int next_level = 0;

    public TMPro.TextMeshProUGUI counter_progress;
    public string counter_text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision other) 
    {
        Destroy(collision.gameObject);
        unwanted_items += 1;    
    }

    // Update is called once per frame
    void Update()
    {

        counter_text = ""; // Resets the text
        counter_text += unwanted_items.ToString();
        counter_text += "/";
        counter_text += required_items.ToString();
        counter_text += " items";

        counter_progress.text = counter_text;

        if (unwanted_items >= required_items)
        {
            SceneManager.LoadScene(next_level);
        }
    }
}
