﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	int max;
	int min;	
	int guess;


	// Use this for initialization
	void Start () {
		startGame();
	}

	void startGame() {
		max = 1000;
		min = 1;
		guess = 500;

		Debug.Log("Welcome to Number Wizard");
		Debug.Log("Pick a number: ");
		Debug.Log("The highest number you can pick is " + max);
		Debug.Log("The lowest number you can pick is " + min);
		Debug.Log("Tell me if your number is higher or lower than " + guess);
		Debug.Log("Push Up = higher, Push Down = lower, Push Enter = Correct!");
		max = max + 1;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.UpArrow)) {
			min = guess;
			nextGuess();
		}

		else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			max = guess;
			nextGuess
		}

		else if (Input.GetKeyDown(KeyCode.Return)) {
			Debug.Log("This is the answer");
		}
	}

	void nextGuess() {
		guess = (max + min) / 2;
		Debug.Log("Is you number higher or lower than" + guess);
	}
}
