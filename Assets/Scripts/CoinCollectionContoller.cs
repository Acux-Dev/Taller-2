using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinCollectionContoller : MonoBehaviour
{

    public GameObject victoryMenuUI;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Time.timeScale = 0f;
            victoryMenuUI.SetActive(true);
            AudioListener.volume = 0f;
        }
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        victoryMenuUI.SetActive(false);
        AudioListener.volume = 1f;
        SceneManager.LoadScene("Game");
    }
}
