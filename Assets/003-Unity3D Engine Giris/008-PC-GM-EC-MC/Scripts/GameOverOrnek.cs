using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverOrnek : MonoBehaviour
{
    [SerializeField] GameObject _GameoverPanel;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Dusman")|| collision.gameObject.CompareTag("Yer"))
        {
            Time.timeScale = 0;
            _GameoverPanel.SetActive(true);
        }
    }

   
    public void ButtonActive()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;

    }
}
