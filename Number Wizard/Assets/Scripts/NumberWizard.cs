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
    // Function to Start the game
    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        print("=========================================");
        print("Welcome to Number Wizard!!");
        print("Pick a number in your head, but don't tell me!");

        print("The highest number you can pick in is " + max);
        print("The lower number you can pick in is " + min);

        print("Is the number higher or lower than " + guess + "?");
        print("Up = higher, down = lower, return = equal.");

        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("The number is equals " + guess + "!");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        print("Is the number higher or lower than " + guess + "?");
    }
}
