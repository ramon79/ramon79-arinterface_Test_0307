using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimButton : MonoBehaviour {

	public Button startBtn;
	public Animator anim;

	void Start() {
		startBtn.onClick.AddListener(AnimOnClick);
	}

	void AnimOnClick() {
		if(null !=anim) {
			anim.Play("NewOpen",0,0.25f);
		}

	}
}
