using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSwitcher : MonoBehaviour
{

    public void SwitchToScene(int new_scene)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(new_scene);
    }

    public void ApplicationEnd()
    {
        Application.Quit();
    }

}
