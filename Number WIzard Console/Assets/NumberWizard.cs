using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
       
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500; 

        Debug.Log("Benvenuti a Number Wizard stronzi!");
        Debug.Log("Scegli un numero:");
        Debug.Log("Il massimo è " + max);
        Debug.Log("Il minimo è " + min);
        Debug.Log("Dimmi se il tuo numero è più alto o più basso di " + guess);
        Debug.Log("Premi Up= più alto, premi Down = più basso, Premi Enter = Corretto!");
        max = max + 1;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow key was pressed");
            min = guess;
            NextGuess();
          
        }
            
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow key was pressed");
            max = guess;
            NextGuess();
        }
            
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Uuuuhh I'm a boss");
            StartGame();

        }

        void NextGuess()
        {
            guess = (max + min) / 2;
            Debug.Log("E' più alto o più basso di " + guess);
            
        }
    }
}
