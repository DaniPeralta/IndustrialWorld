using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		
	}

	public void button1Push(){
		GameController.hits++;

		if(!GameController.actionsButtons["S1"])
		{
			GameController.actionsButtons ["S1"] = true;
			Debug.Log ("pulsado el botón 1 BIEN");
		}
		else
		{ 
			GameController.fail++;
			Debug.Log ("pulsado el botón 1 MAL"); 
		}
	}

	public void button2Push(){
		GameController.hits++;

		if(!GameController.actionsButtons["S2"] && GameController.actionsButtons["S1"])
		{
			GameController.actionsButtons ["S2"] = true;
			Debug.Log ("pulsado el botón 2 BIEN");

		}else {GameController.fail++;
			Debug.Log ("pulsado el botón 2 MAL");}
	}

	public void button3Push(){
		GameController.hits++;

		if(!GameController.actionsButtons["S3"] && GameController.actionsButtons["S2"])
		{
			GameController.actionsButtons ["S3"] = true;
			Debug.Log ("pulsado el botón 3 BIEN");

		}else {GameController.fail++;
			Debug.Log ("pulsado el botón 3 MAL");}
	}

	public void button4Push(){
		GameController.hits++;

		if(!GameController.actionsButtons["S4"] && GameController.actionsButtons["S3"])
		{
			GameController.actionsButtons ["S4"] = true;
			GameController.end = true;
			Debug.Log ("pulsado el botón 4 BIEN");

		}else {GameController.fail++;
			Debug.Log ("pulsado el botón 4 MAL");}
	}

	public void badButton(){
		GameController.hits++;
		GameController.fail++;
	}
}
