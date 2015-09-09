using UnityEngine;
using System.Collections;

public class Paused : MonoBehaviour {
	public static bool paused;
	public GameObject p_butt;
	public GameObject image;



	// Use this for initialization
	void Start () {
		paused = false;

	}
	public void PauseButtonClick(){
		paused = !paused;
		p_butt.SetActive (false);
		image.SetActive (true);

	}

	public void ResumeButtonClick(){
		p_butt.SetActive (true);
		image.SetActive (false);

		paused = false;
	
	}


}
	

