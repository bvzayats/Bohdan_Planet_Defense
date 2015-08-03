using UnityEngine;
using System.Collections;

public class ShowRecords : MonoBehaviour {

	public GameObject Showpanel;
	public GameObject[] RecordText;
	// Use this for initialization
	void Start () {
		Showpanel.SetActive (false);
		for (int i =0; i<RecordText.Length; i++) {
			RecordText[i].SetActive(false);
		}
	}

	public void RecordsButtonClicked()
	{
		Showpanel.SetActive (true);
		for (int i =0; i<RecordText.Length; i++) {
			RecordText[i].SetActive(true);
		}
		
	}
	public void BackButtonClicked()
	{
		Showpanel.SetActive (false);
		for (int i =0; i<RecordText.Length; i++) {
			RecordText[i].SetActive(false);
		}
		
	}
	// Update is called once per frame
	void Update () {
	
	}
}
