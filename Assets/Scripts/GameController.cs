using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameController : MonoBehaviour {

	public static Dictionary<string, bool> actions = new Dictionary<string, bool>();
	public static Dictionary<string, bool> actionsButtons = new Dictionary<string, bool>();

	public static int hits = 0;
	public static int fail = 0;

	public GameObject endGame;
	public GameObject gameOver;

	public static bool end = false;

	// Use this for initialization
	void Start () {
		
		actions.Add ("P1", false);
		actions.Add ("P2", false);
		actions.Add ("V1", false);
		actions.Add ("V2", false);
		actions.Add ("MateNotified", false);

		actionsButtons.Add ("S1", false);
		actionsButtons.Add ("S2", false);
		actionsButtons.Add ("S3", false);
		actionsButtons.Add ("S4", false);
	}
	
	// Update is called once per frame
	void Update () {
		
		if(actions["MateNotified"] == true)
		{
			endGame.SetActive (true);
		}

		if(end){
			endGame.SetActive (false);

			Text text = gameOver.GetComponent<Text> ();

			text.text = "Intentos: " + hits + "\nFallos: " + fail + "\nEficiencia: " + Math.Round(((float)(hits-fail) / hits) * 100,2)+"%";
			gameOver.SetActive (true);

			Debug.Log ("Juego terminado");
		}
	}
}
