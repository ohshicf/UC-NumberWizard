using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;

    // Use this for initialization
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        min = 1;
        max = 1000;
        print("Welcome to Number Wizard");
        print(string.Format("Choose a number between {0:D} and {1:D} in your head, but don't tell me.", min, max));
        max++;
        NextGuess();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                min = guess;
                NextGuess();
            } else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                max = guess;
                NextGuess();
            } else if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                print("I won!");
                StartGame();
            }
    }

    void NextGuess()
    {
        guess = min + (max - min) / 2;
        print(string.Format("Is the number higher or lower than {0:D}?", guess));
        print("Up = higher, down = lower, return = equal:");

    }
}
