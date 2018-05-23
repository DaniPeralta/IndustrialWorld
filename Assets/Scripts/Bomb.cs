using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bomb : MonoBehaviour {

	[SerializeField] private Animator m_animator;
	public string action;

	public Camera GUICamera;

	public GameObject player;
	//public Text texto;

	// Use this for initialization
	void Start () {

		 //Transform p = player.GetComponent<Transform> ();

	
		//Debug.Log (transform.position);
		//float offsetPosY = transform.position.y + 1.5f;

		//Vector3 offsetPos = new Vector3 (transform.position.x, offsetPosY, transform.position.z);

		//Vector2 screenPoint = Camera.main.WorldToScreenPoint (transform.position);

		//Debug.Log ("OffsetPos: " + offsetPos);
	//	Debug.Log ("screenPoint: " + screenPoint);

	//	texto.transform.position = screenPoint;
		/*Vector2 canvasPos;
		Vector2 screenPoint = Camera.main.WorldToScreenPoint (offsetPos);
		 
		RectTransformUtility.ScreenPointToLocalPointInRectangle (new Rect(transform.position.x,transform.position.y,100,100), screenPoint, null, out canvasPos);

		texto.transform.position = canvasPos;*/
		//texto.transform.position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
//		texto.transform.position= transform.position;
	//	Debug.Log ("Texto: "+texto.transform.position);
	//	Debug.Log ("Pos: "+transform.position);
	//	Vector2 screenPoint = Camera.main.WorldToScreenPoint (transform.position);

		//Debug.Log ("OffsetPos: " + offsetPos);
	//	Debug.Log ("screenPoint: " + screenPoint);

//		texto.transform.position = screenPoint;
	/*	Vector3 distancia = new Vector3();
		distancia = transform.position - player.transform.position;


		Debug.Log("Elemento: "+action+" distancia= "+ distancia);
		//Debug.Log("Elemento: "+action+" magnitude= "+ distancia.magnitude);
		Debug.Log("Elemento: "+action+" direction= "+ (distancia / distancia.magnitude));*/

	}
		

	void OnMouseDown() {
		
	//	Debug.Log ("Antes: "+GameController.actions [action]);
		Vector3 heading = new Vector3();
		heading = transform.position - player.transform.position;

		Debug.Log ("Intentos: "+GameController.hits);
		if (heading.magnitude < 0.6) {
			GameController.hits++;
			if (GameController.actions [action] == false) {
				switch (action) {
				case "P1":
					m_animator.SetTrigger ("Pickup");
					GameController.actions [action] = true;
					break;
				case "P2":
					if (GameController.actions ["P1"] == true) {
						m_animator.SetTrigger ("Pickup");
						GameController.actions [action] = true;
					} else
						GameController.fail++;
					break;
				case "V1":
					if (GameController.actions ["P2"] == true) {
						m_animator.SetTrigger ("Pickup");
						GameController.actions [action] = true;
					} else
						GameController.fail++;
					break;
				case "V2":
					if (GameController.actions ["V1"] == true) {
						m_animator.SetTrigger ("Pickup");
						GameController.actions [action] = true;
					} else
						GameController.fail++;
					break;
			/*	case "MateNotified":
					if (GameController.actions ["V2"] == true) {
						m_animator.SetTrigger ("Wave");
						GameController.actions [action] = true;
					} else
						GameController.fail++;
					break;*/
				}
			}
			else
			{
				GameController.fail++;
			}
		}
		else
		{
			if(action == "MateNotified")
			{
				GameController.hits++;
				if (GameController.actions ["V2"] == true && GameController.actions[action] == false) 
				{
					m_animator.SetTrigger ("Wave");
					GameController.actions [action] = true;
				} 
				else
					GameController.fail++;
			}
		}

	//	Debug.Log ("Después: " + GameController.actions [action]);
		Debug.Log ("Fallos: " + GameController.fail);
	}

}
