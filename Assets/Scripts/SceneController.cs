using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

	string firstWinScene = "WinFirstScene";
	string	secondWinScene="WinSecondScene";
	string	thirdWinScene="WinThirdScene";
	
	
	//Method to load scene "Name" on click of button
	public void LoadTheScene(string name){
		SceneManager.LoadScene(name, LoadSceneMode.Single);
	}
	
	//Method to quit the game when button of quit is clicked
	public void QuitTheGame(){
		Application.Quit();
	}


	//Method to choose a winning scene when the button is clicked based on the number of tries to guess
	public void ChooshingWinScene(int numberGuessesAllowed_reference){ //number of tries left - 1
		if(numberGuessesAllowed_reference==0){ //won on the last try
			LoadTheScene(firstWinScene);
		}
		else if(numberGuessesAllowed_reference>1 && numberGuessesAllowed_reference<5){ //won with left tries between 2 and 5
			LoadTheScene(secondWinScene);			
		}
		else{ 
			LoadTheScene(thirdWinScene);			
		}
	}	

}
