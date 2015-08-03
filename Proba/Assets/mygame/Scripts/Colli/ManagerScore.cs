using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ManagerScore : MonoBehaviour
{
	public static int score;        // The player's score.
	public GameObject record1;
	public GameObject record2;
	public GameObject record3;


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
		if (score > PlayerPrefs.GetInt("Score1")) {
			PlayerPrefs.SetInt ("Score1", score);
			if(PlayerPrefs.GetInt("Score1")==0){
				record1.GetComponent<Text>().text= "score";
			}else
			{record1.GetComponent<Text>().text= ""+ PlayerPrefs.GetInt("Score1");}
			//PlayerPrefs.Se("Time1_min",(int) ManagerTime.time_min);
			//PlayerPrefs.SetString("Time1_sec",(string) ManagerTime.time_sec);
		}
		if (score < PlayerPrefs.GetInt ("Score1") && score > PlayerPrefs.GetInt ("Score2")) {
			PlayerPrefs.SetInt ("Score2", score);
			if(PlayerPrefs.GetInt("Score2")==0){
				record2.GetComponent<Text>().text= "score: ";
			}
			else
			{record2.GetComponent<Text>().text=""+ PlayerPrefs.GetInt("Score2");}
			//PlayerPrefs.SetString("Time2_min",(string) ManagerTime.time_min);
			//PlayerPrefs.SetString("Time2_sec",(string) ManagerTime.time_sec);
		}
		if (score < PlayerPrefs.GetInt ("Score2") && score > PlayerPrefs.GetInt ("Score3")) {
			PlayerPrefs.SetInt ("Score3", score);
			if(PlayerPrefs.GetInt("Score3")==0){
				record3.GetComponent<Text>().text= "score: ";
			}else
			{record3.GetComponent<Text>().text=""+ PlayerPrefs.GetInt("Score3");}
			//PlayerPrefs.SetString("Time3_min",(string) ManagerTime.time_min);
			//PlayerPrefs.SetString("Time3_sec",(string) ManagerTime.time_sec);
		}
	
		// Set the displayed text to be the word "Score" followed by the score value.
		text.text = "Score: " + score + "|" + PlayerPrefs.GetInt("Score1");
	}
}