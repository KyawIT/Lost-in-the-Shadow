using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public Text goldAmount;

    public void Setup(int coinAmt)
    {
        gameObject.SetActive(true);
        goldAmount.text = coinAmt.ToString() + "GOLD";
    }
}
