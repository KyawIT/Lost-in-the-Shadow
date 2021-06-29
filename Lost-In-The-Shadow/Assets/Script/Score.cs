using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text textScore;
    // Start is called before the first frame update
    void Update()
    {
        textScore.text = "Coin "+ CoinCounter.coinAmount.ToString();
    }
}
