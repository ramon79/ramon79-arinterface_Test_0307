using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnim : MonoBehaviour {

	

	private Animator Anim;

	//public GameObject doorButton;

	// Use this for initialization
	void Start () {
		Anim = GetComponent<Animator>();
		Anim.speed = 0f;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AnimOpen()
	{
		Anim.Play("NewOpen", -1, 0f);
		Anim.speed = 1f;
	}

	public void AnimClose()
	{
		Anim.Play("NewClose", -1, 0f);
		Anim.speed = 1f;
	}
}
