using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityARInterface;
using UnityEngine.SceneManagement;

public class PlaceCar : MonoBehaviour {


	public Button PlaceGameObjectBtn;
	private ARPointCloudVisualizer ARPointCloudVisualizer;
	private ARPlaneVisualizer ARPlaneVisualizer;
	public GameObject colorsPanel;
	public GameObject functionsPanel;
	public GameObject portionPanel;
	public GameObject drivingJoystick;
	public GameObject playmode;
	public Button restart;



	public void onClickPlaceGameObject ()
	{
		var planes = GameObject.FindGameObjectsWithTag ("planeTag");
		var particles = GameObject.FindGameObjectsWithTag ("particleTag");

		foreach (var plane in planes) 
		{
			Destroy (plane);
		}

		foreach (var particle in particles) 
		{
			Destroy (particle);
		}

		ARPointCloudVisualizer = GameObject.Find ("AR Root").GetComponent<ARPointCloudVisualizer> ();
		ARPlaneVisualizer = GameObject.Find ("AR Root").GetComponent<ARPlaneVisualizer> ();

		Destroy (ARPointCloudVisualizer);
		Destroy (ARPlaneVisualizer);
		Destroy (GameObject.Find("FocusSquare")); 

		PlaceGameObjectBtn.gameObject.SetActive (false);
		playmode.gameObject.SetActive(true);
		GameObject.Find("Canvas").GetComponent<PortionControl>().Small(); // placecar 이후 최소 사이즈로 시작

	}

public void onClickExplore() {

		colorsPanel.gameObject.SetActive(true);
		functionsPanel.gameObject.SetActive(true);
		portionPanel.gameObject.SetActive(true);
		drivingJoystick.gameObject.SetActive(false);
		restart.gameObject.SetActive(true);

}
public void onClickDrive() {

		colorsPanel.gameObject.SetActive(false);
		functionsPanel.gameObject.SetActive(false);
		portionPanel.gameObject.SetActive(false);
		drivingJoystick.gameObject.SetActive(true);
		restart.gameObject.SetActive(true);

}

public void onClickRestart(string arinterface_Test2) {

	GameObject.Destroy (GameObject.Find ("AR Root"));
	SceneManager.LoadScene(arinterface_Test2);
	

}
}
