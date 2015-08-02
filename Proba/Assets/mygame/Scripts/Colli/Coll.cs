using UnityEngine; 
using System.Collections; 
public class Coll : MonoBehaviour { 

	public Rigidbody2D b;
	public Rigidbody2D d;
	public Rigidbody2D c;
	public GameObject planet;
	private float a ;
	public Camera main;
	public static Vector3 world;
	public static float asd;

	void Start () {
		
		world = Camera.main.ScreenToWorldPoint(new Vector3(0.0f, 0.0f, -6.0f));
		asd = (world.x * -2);
		asd = asd / 30;
		
		planet.transform.localScale = new Vector2 (asd, asd);
		a = asd;
		
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		
		Destroy (other.gameObject);
		
		if (other.name == "Bird(Clone)") {
			a += b.mass / 35;
		}
		
		if( other.name =="Bird1(Clone)"){
			a += d.mass/35;
		}
		if( other.name =="Bird2(Clone)"){
			a += c.mass/35;
		}
		
		
		planet.transform.localScale = new Vector2 (a, a);
	}
	}
