using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            CoinCounter.coinAmount += 1;
            Destroy(gameObject);
            if (CoinCounter.coinAmount == 10)
            {
                SceneManager.LoadScene("End_Scene");
            }
        }
    }
}
