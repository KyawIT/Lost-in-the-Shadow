using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport_lvl2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision) //Make sure to put this out of Voids
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Collided");
            SceneManager.LoadScene("Game_LVL2");

        }
    }
}
