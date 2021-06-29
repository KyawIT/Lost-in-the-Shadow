using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public void EndGame()
    {
        Debug.Log("GameOver");
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(4);
    }
}
