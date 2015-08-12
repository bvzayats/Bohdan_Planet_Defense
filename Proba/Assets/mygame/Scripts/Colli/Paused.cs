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

	}

	public void ResumeButtonClick(){
		p_butt.SetActive (true);

		paused = false;
	
	}


}
	

