using UnityEngine;
using System.Collections;

public class Paused : MonoBehaviour {
	public static bool paused;

	// Use this for initialization
	void Start () {
		paused = false;

	}
	
	public void PauseButtonClicked()
	{
		paused = !paused;
		if (paused) {

			Time.timeScale = 1;
			
		} 
	}



}