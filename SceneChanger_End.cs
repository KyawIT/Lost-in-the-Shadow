using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger_End : MonoBehaviour
{
    public void ChangeScene_End()
    {
        // If Player is on Intro Scene and pressed Quit then goto last Scene to Quit
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        }
    }
}
