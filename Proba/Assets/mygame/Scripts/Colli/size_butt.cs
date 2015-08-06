using UnityEngine;
using System.Collections;

public class size_butt : MonoBehaviour {
	
	public Vector3 world;
	public float asd;
	public Camera mainCam;
	
	// Use this for initialization
	void Start () {

		world = Camera.main.ScreenToWorldPoint(new Vector3(0.0f, 0.0f, -6.0f));
		asd = (world.x * -2);
		double sdf = asd / 6;
		this.gameObject.transform.localScale = new Vector3 ((float) sdf, (float)sdf,1);
		
	}
	
}
