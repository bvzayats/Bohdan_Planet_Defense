using UnityEngine;
using System.Collections;

public class die : MonoBehaviour {
	public GameObject ui;
	public GameObject Game_over;
	public GameObject bird;
	public GameObject planet;
	public GameObject birds;
	public GameObject birds1;
	public GameObject birds2;
	public Camera main;
	public Vector3 world;
	public float asd;
	public static float end_screen;
	
	void Start(){
		birds.GetComponent<SpriteRenderer>().enabled=true;
		birds1.GetComponent<SpriteRenderer>().enabled=true;
		birds2.GetComponent<SpriteRenderer> ().enabled = true;
	}
	// Use this for initialization
	void Update () {
		
		world = Camera.main.ScreenToWorldPoint(new Vector3(0.0f, 0.0f, -6.0f));
		
		asd = (world.x * -2);
		
		end_screen = asd / 4.862014f;
		
		print(asd);
		
		if (this.gameObject.transform.lossyScale.x >= end_screen - end_screen / 20 ) {
			
			birds.GetComponent<SpriteRenderer>().enabled=false;
			birds1.GetComponent<SpriteRenderer>().enabled=false;
			birds2.GetComponent<SpriteRenderer> ().enabled = false;
		}
		
		if (this.gameObject.transform.lossyScale.x >= end_screen) {
			
			bird.SetActive(false);
			
			planet.SetActive(false);
			ui.SetActive(true);
			Game_over.SetActive(true);
			
		}
	}
}



		
		
		

