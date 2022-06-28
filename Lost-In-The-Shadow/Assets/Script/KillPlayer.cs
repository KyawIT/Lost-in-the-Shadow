using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class KillPlayer : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        // If the player collide (btw.: the player has the TAG "player")
        if (other.CompareTag("Player"))
        {
            CoinCounter.coinAmount = 0;
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
