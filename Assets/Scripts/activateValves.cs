using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateValves : MonoBehaviour {

	public GameObject smoke;
	public GameObject smoke2;
	public GameObject rain;
	bool active1 = true;
	bool active2 = false;

	void Update()
	{
		
	}

	void OnCollisionStay(Collision collision)
	{

		if(collision.gameObject.CompareTag("Valve"))
		{
			bool turnValve = Input.GetKeyDown(KeyCode.Tab);

			if(turnValve){
				if(active1){
					smoke.SetActive (false); 
					smoke2.SetActive (true);
					active1 = false;
					active2 = true;
				}
			}
		}

		if(collision.gameObject.CompareTag("Valve1"))
		{
			bool turnValve = Input.GetKeyDown(KeyCode.Tab);
			if(turnValve){
				if(active2){
					smoke2.SetActive (false);
					active2 = false;
					rain.SetActive (true);
				}
			}
		}
	}
}
