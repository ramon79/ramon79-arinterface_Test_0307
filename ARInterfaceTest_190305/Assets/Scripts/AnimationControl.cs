using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;
using UnityEngine.EventSystems;
public class AnimationControl : MonoBehaviour,IPointerDownHandler,IPointerUpHandler  {

 Animation openDoor;
bool check;

void Start () {
		openDoor = GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update () {

		if (check)
			openDoor.enabled= true;
	}

public void OnPointerDown(PointerEventData eventData)
	{
		
		check = true;
		//car.transform.Translate(Vector3.forward*speed*Time.deltaTime);

	}
		public void OnPointerUp(PointerEventData eventData)
	{
		
		check = false;
		//car.transform.Translate(Vector3.forward*speed*Time.deltaTime);

	}





}
