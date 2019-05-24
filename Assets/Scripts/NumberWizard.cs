using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int maxNumber = 1000;
    int minNumber = 1;
    int initialGuess = 500;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("Pick a number between 1-1000, but don't tell me what it is...");
        Debug.Log("The highest number you can pick is " + maxNumber + ".");
        Debug.Log("The lowest number you can pick is " + minNumber + ".");
        Debug.Log("Tell me if your number is higher or lower than " + initialGuess + ".");
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        maxNumber = maxNumber + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)){
            minNumber = initialGuess;
            initialGuess = (maxNumber + minNumber) / 2;
            Debug.Log("Is it higher or lower than " + initialGuess);
        }else if (Input.GetKeyDown(KeyCode.DownArrow)){
            maxNumber = initialGuess;
            initialGuess = (maxNumber + minNumber) / 2;
            Debug.Log("Is it higher or lower than " + initialGuess);
        }else if (Input.GetKeyDown(KeyCode.Return)){
            Debug.Log("I guessed correctly");
        }
    }
}
