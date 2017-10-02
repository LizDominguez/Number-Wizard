using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class NumberWizard : MonoBehaviour {

	int max, min, guess;
	public int maxGuessesAllowed = 10;
	public Text text;

	// Use this for initialization
	void Start () {

		StartGame ();


	}

	void StartGame () {
		max = 1000 + 1;
		min = 1;
		NextGuess();

	}


	public void NextGuess() {

		guess = Random.Range(min, max);
		text.text = guess.ToString();
		maxGuessesAllowed -= 1;

		if (maxGuessesAllowed <= 0) {
			SceneManager.LoadScene("Win");
		}

	}


	public void GuessLower() {

		max = guess;
		NextGuess();

	}


	public void GuessHigher() {

		min = guess;
		NextGuess();

	}


	public void Correct() {

		SceneManager.LoadScene("Lose");

	}

}
