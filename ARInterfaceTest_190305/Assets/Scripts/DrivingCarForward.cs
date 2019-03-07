using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityStandardAssets.CrossPlatformInput;

public class DrivingCarForward : MonoBehaviour, IPointerDownHandler,IPointerUpHandler{


public GameObject car;
public Transform player;
float speed = 40;
bool check;
	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {

		if (check)
			car.transform.Translate(Vector3.forward*speed*Time.deltaTime);
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
	/* /public void Up()
	{
		
		check = true;
		//car.transform.Translate(Vector3.forward*speed*Time.deltaTime);

	}
	public void Down()
	{
			car.transform.Translate(Vector3.back*speed);	
	}
	public void Left()
	{
				car.transform.Translate(Vector3.left*speed);
	}
	public void Right()
	{
				car.transform.Translate(Vector3.right*speed);
	}*/

}
