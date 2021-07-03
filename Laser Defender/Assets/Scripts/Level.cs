using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    [SerializeField] float delayInSeconds = 2f;
    public void LoadStartMenu() {
        SceneManager.LoadScene(0);
    }

    public void LoadMainGame() {
        SceneManager.LoadScene("Game");
    }

    public void LoadGameOver() {
        Debug.Log("Hello");
        StartCoroutine(Delay());
        
    }

    public void QuitGame() {
        Application.Quit();
    }

    IEnumerator Delay() {
        yield return new WaitForSeconds(delayInSeconds);
        SceneManager.LoadScene("Over");
    }
}
