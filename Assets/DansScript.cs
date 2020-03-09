using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DansScript : MonoBehaviour {

	private Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}

	public void DanceStart()
	{
		anim.enabled = true;
	}

	public void DanceStop()
	{
		anim.enabled = false;
	}
}
