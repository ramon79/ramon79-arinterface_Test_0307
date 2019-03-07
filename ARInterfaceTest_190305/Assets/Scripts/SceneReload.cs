using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneReload : MonoBehaviour {
	// Use this for initialization
	IEnumerator Start(){
		AsyncOperation async = Application.LoadLevelAsync("arinterface_Test2");
		yield return async;
		
	}
}
