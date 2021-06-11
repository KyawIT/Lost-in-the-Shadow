using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Libary for changing Scene

public class SceneChanger : MonoBehaviour
{
    public void ChangeScene()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0) // if the build index is 0
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Change to second scene
        }
    }
}
