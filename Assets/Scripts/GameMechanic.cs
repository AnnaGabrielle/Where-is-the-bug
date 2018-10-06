using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMechanic : MonoBehaviour {

	[SerializeField] int max;  
	[SerializeField] int min; 
	[SerializeField] int numberGuessesAllowed;
	[SerializeField] Text guessedNumber;
	[SerializeField] Text numberOfGuesses;
	[SerializeField] string loseScreen;

	int guessMade;

	public SceneController sceneController; //to get the method of the script SceneController

	// Starts the game with the first guess
	void Start () {
		NextGuess();
	}

	//Method for when the number guessed should be higher
	public void HigherNumber(){
		min = guessMade + 1;
		NextGuess();
	}

	//Method for when the number guessed should be lower
	public void LowerNumber(){
		max = guessMade - 1;
		NextGuess();
	}
	
	// Method for the guess and print the result and number of guesses left on screen
	public void NextGuess () {
		guessMade = Random.Range(min, max+1);  
		guessedNumber.text = guessMade.ToString();
		numberOfGuesses.text = numberGuessesAllowed.ToString();
		if(numberGuessesAllowed <= 0){ //loses game when there are no more tries left
			sceneController.LoadTheScene(loseScreen);
		}
		numberGuessesAllowed--;
	}

	//Method to load the correct winning scene for the correct button
	public void CorrectGuess(){
		sceneController.ChooshingWinScene(numberGuessesAllowed);
	}
}
