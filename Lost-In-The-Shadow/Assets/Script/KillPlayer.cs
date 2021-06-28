using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class KillPlayer : MonoBehaviour
{
    private int respawn;
    public GameOverScreen gameOver;
    private void Start()
    {
        respawn = SceneManager.GetActiveScene().buildIndex;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        // If the player collide (btw.: the player has the TAG "player")
        if (other.CompareTag("Player"))
        {
            gameOver.Setup(CoinCounter.coinAmount);
            SceneManager.LoadScene(respawn);
        }
    }
}
