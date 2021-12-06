using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartSButton : MonoBehaviour
{
    public void Restart()
    {
        // aaaaaa
        SceneManager.LoadScene("SampleScene");
    }
}