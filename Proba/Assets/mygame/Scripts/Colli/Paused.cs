using UnityEngine;
using System.Collections;

public class Paused : MonoBehaviour {
	public static bool paused;
	public GameObject p_butt;

	// Use this for initialization
	void Start () {
		paused = false;

	}
	public void PauseButtonClick(){
		paused = !paused;
		p_butt.SetActive (false);
		if (paused) {
			Time.timeScale = 1;
		}
	}

	public void ResumeButtonClick(){
		p_butt.SetActive (true);
		paused = false;
	}


}
	

