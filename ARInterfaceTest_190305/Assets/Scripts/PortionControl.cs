using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortionControl : MonoBehaviour {
	
	public GameObject car;
	public void Small() 
	{
		car.transform.localScale = new Vector3(1, 1, 1);
	}
	public void Middle() 
	{
		car.transform.localScale= new Vector3(3,3,3);
	}
	public void Big() 
	{
		car.transform.localScale= new Vector3(5,5,5);
	}
	// Use this for initialization
}
