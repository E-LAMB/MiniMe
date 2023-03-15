using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Buttons : MonoBehaviour
{

    public string[] content_array;

    public GameObject loading_warning;

    public char my_char;

    public UnityEngine.UI.Slider sli_th;
    public UnityEngine.UI.Slider sli_in;
    public UnityEngine.UI.Slider sli_li;
    public UnityEngine.UI.Slider sli_ht;
    public UnityEngine.UI.Toggle tog_he;
    public UnityEngine.UI.Slider sli_sp;
    public UnityEngine.UI.Slider sli_wt;
    public UnityEngine.UI.Slider sli_by;

    void Start()
    {
        if (!Mind.has_found_mic)
        {
            Mind.has_found_mic = true;
            Mind.mic_to_use = 0;
        }

        if (!Mind.has_found_location)
        {
            Mind.file_path = Application.persistentDataPath + "/pngtubersavedata.txt";
            Mind.file_pre_existed = File.Exists(Mind.file_path);
            if (!Mind.file_pre_existed) {File.Create(Mind.file_path);} else {Debug.Log("Exists!");}
            if (!Mind.file_pre_existed) {butt_save_savedata();} else {Mind.saved_data_avaliable = true;}
            Mind.has_found_location = true;
        }

    }

    void Update()
    {
        if (Mind.maximum_mics < Mind.mic_to_use)
        {
            Mind.mic_to_use = Mind.maximum_mics;
        }
        Mind.maximum_mics = Microphone.devices.Length - 1;

        loading_warning.SetActive(!Mind.saved_data_avaliable);
    }

    public void butt_save_savedata()
    {
        Mind.saved_data_avaliable = true;
        string content;

        content = Mind.mind_threshold.ToString() + "/" + Mind.mind_intensity.ToString() + "/" + Mind.mind_linger.ToString() + "/" + Mind.mind_hop_amount.ToString() + "/" + Mind.mind_hop_bool.ToString() + "/" + Mind.mind_hop_speed.ToString() + "/" + Mind.mind_hop_wait.ToString() + "/" + Mind.boyancy_intensity.ToString();

        StreamWriter writer = new StreamWriter(Mind.file_path, false);
        writer.Write(content);
        Debug.Log(content);
        writer.Close();
    }

    public void butt_load_savedata()
    {
        if (Mind.saved_data_avaliable)
        {

            StreamReader reader = new StreamReader(Mind.file_path);
            string content;
            content = reader.ReadToEnd(); // Reads the content in the file
            reader.Close();
            Debug.Log(content); 

            content_array = content.Split(my_char);

            sli_th.value = float.Parse(content_array[0]);
            sli_in.value = float.Parse(content_array[1]);
            sli_li.value = float.Parse(content_array[2]);
            sli_ht.value = float.Parse(content_array[3]);
            tog_he.isOn = bool.Parse(content_array[4]);
            sli_sp.value = float.Parse(content_array[5]);
            sli_wt.value = float.Parse(content_array[6]);
            sli_by.value = float.Parse(content_array[7]);

        } else
        {
            Debug.Log("No Saved Data Found");
        }
    }

    public void butt_quit()
    {
        Debug.Log("Program was quit");
        Application.Quit();
    }

    public void butt_reload()
    {
        Debug.Log("Program was reloaded");
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

}
