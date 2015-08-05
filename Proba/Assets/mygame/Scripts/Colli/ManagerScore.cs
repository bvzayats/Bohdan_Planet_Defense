using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ManagerScore : MonoBehaviour
{
	public static int score;  
	public GameObject gameover;// The player's score.
	
	Text text;                      // Reference to the Text component.
	

	void Start(){

	}
	void Awake ()
	{

		// Set up the reference.
		text = GetComponent <Text> ();

		// Reset the score.
		score = 0;
	}
	
	
	void Update ()
	{
	
			if (score > PlayerPrefs.GetInt ("Score1")) {
				PlayerPrefs.SetInt ("Score1", score);
				PlayerPrefs.SetString ("Timer1", ManagerTime.time_game);
		
			}
			/*if (score < PlayerPrefs.GetInt ("Score1") && score > PlayerPrefs.GetInt ("Score2")) {
				PlayerPrefs.SetInt ("Score2", score);
				PlayerPrefs.SetString ("Timer2", ManagerTime.time_game);

			}
			if (score < PlayerPrefs.GetInt ("Score2") && score > PlayerPrefs.GetInt ("Score3")) {
				PlayerPrefs.SetInt ("Score3", score);
				PlayerPrefs.SetString ("Timer3", ManagerTime.time_game);
			}
*/
	
		// Set the displayed text to be the word "Score" followed by the score value.
		text.text = "Score: " + score + "|" + PlayerPrefs.GetInt("Score1");
	}
}