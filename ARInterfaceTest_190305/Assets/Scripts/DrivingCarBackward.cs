using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.EventSystems;
public class DrivingCarBackward : MonoBehaviour,IPointerDownHandler,IPointerUpHandler {

public GameObject car;
float speed = 40;
bool check;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (check)
			car.transform.Translate(Vector3.back*speed*Time.deltaTime);
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
