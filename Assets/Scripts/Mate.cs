using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mate : MonoBehaviour {

	[SerializeField] private Animator m_animator;

	// Use this for initialization
	void OnMouseDown()
	{
		m_animator.SetTrigger ("Wave");
	}
}
