using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

	public Image currentL1;
	public Image currentL2;

	float tL1 = 0;
	float tL2 = 0;

	private void Update(){
		UpdateL1 ();
		UpdateL2 ();
	}

	private void UpdateL1(){
		
		tL1 += Time.deltaTime / 100;
		currentL1.rectTransform.localScale = new Vector3(1, Mathf.Lerp(0, 1, tL1), 1);
		//currentL1.transform.position = new Vector3(Mathf.Lerp(0, 1000, t), 0, 0);

	}

	private void UpdateL2()
	{
		if(GameController.actions["P1"] == true)
		{
			tL2 += Time.deltaTime / 200;
			currentL2.rectTransform.localScale = new Vector3(1, Mathf.Lerp(1, 0, tL2), 1);	
		}
	}

}
