using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;
    void Start()
    {
        StartGame();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow)) {
            min = guess;
            NextGuess();
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow)) {
            max = guess;
            NextGuess();
        }
        else if(Input.GetKeyDown(KeyCode.Return)) {
            Debug.Log("Good Game");
            StartGame();
        }
    }

    void StartGame() {
        max = 1001;
        min = 1;
        guess = 500;
        Debug.Log("Welcome to number wizard");
        Debug.Log("Pick a number: ");
        Debug.Log("Highest Number is: " + max);
        Debug.Log("Lowest Number is: " + min);
        Debug.Log("Tell me if your number is higher or lower than: " + guess);
        Debug.Log("Push Up = higher, Push Down = lower, Push Enter = correct");
    }

    void NextGuess() {
        guess = (max + min) / 2;
        Debug.Log("Tell me if your number is higher or lower than: " + guess);
    }
}
