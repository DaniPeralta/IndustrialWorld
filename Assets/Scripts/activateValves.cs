using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateValves : MonoBehaviour {

	public GameObject smoke;
	public GameObject smoke2;
	public GameObject rain;
	[SerializeField] private Animator m_animator;
	bool active1 = true;
	bool active2 = false;

	public GameObject mate;

	void Update()
	{
		//NotifyMate ();
	}

	void Start()
	{
		mate = GetComponent<GameObject> ();
	}

	void OnCollisionStay(Collision collision)
	{

		if(collision.gameObject.CompareTag("Valve"))
		{
			bool turnValve = Input.GetKeyDown(KeyCode.Tab);

			if(turnValve){
				if(active1){
					m_animator.SetTrigger("Pickup");
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
					m_animator.SetTrigger("Pickup");
					smoke2.SetActive (false);
					active2 = false;
					rain.SetActive (true);
				}
			}
		}
	}
		
	private void NotifyMate()
	{
		if(Input.GetMouseButtonDown(0)){
			m_animator.SetTrigger ("Wave");
		}

	}
}
