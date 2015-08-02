using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

	public GameObject quite;
	public GameObject resume;
	public GameObject restart;
	public GameObject mainmenu;
	// Use this for initialization
	void Start () {
	
	}
	void OnGUI()
	{

		if (Paused.paused) {

			quite.SetActive(true);
			resume.SetActive(true);
			restart.SetActive(true);
			mainmenu.SetActive(true);
			
		} 
		else{
			quite.SetActive(false);
			resume.SetActive(false);
			restart.SetActive(false);
			mainmenu.SetActive(false);

		}
		
	}
	void Update(){
		OnGUI ();
	}
}

