using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textBtn : MonoBehaviour {

	
	

	public Text myText = null;
	public int counter = 0;

	public void changeText()
	{
		counter++;
		if(counter % 2 == 1)
		{
			myText.text = "Open Door";
			GameObject.Find("Left_Door_pivot").GetComponent<DoorAnim>().AnimClose();
		}
		else
		{
			myText.text = "Close Door";
			GameObject.Find("Left_Door_pivot").GetComponent<DoorAnim>().AnimOpen();
			
		}

	}



}
