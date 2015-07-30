using UnityEngine; 
using System.Collections; 
public class Coll : MonoBehaviour { 

	public Rigidbody2D b;
	public Rigidbody2D d;
	public Rigidbody2D c;
	public GameObject planet;
	private float a = 1;
	private float animat=0;

	void OnTriggerEnter2D(Collider2D other)
	{
	
		Destroy (other.gameObject);

		if (other.name == "Bird(Clone)") {
			a += b.mass / 10;
			animat=b.mass / 10;
		}

		if( other.name =="Bird1(Clone)"){
				a += d.mass/10;
				animat=d.mass/10;
			}
		if( other.name =="Bird2(Clone)"){
				a += c.mass/10;
				animat=c.mass/10;
			}
	

			planet.transform.localScale = new Vector2 (a, a);
		}
	}
