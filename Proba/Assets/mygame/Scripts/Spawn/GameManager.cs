using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour 
{
	public GameObject planet;
	public Transform[] spawnPoints; // точки спауну
	public GameObject[] enemyPrefabs; // масив обєктів які спамитумуться
	private GameObject[] spawn_obj; //масив де зберігаються всі заспамлені обєкти
	public int amountEnemies=1; // загальна кіклькість астероїдів які заспамляться 
	public int count_point_spawn;
	private int a = 0;
	private float x=0,y=0;
	public int yieldTimeMin; // мінімальний час появлення астероїдів(спавну)
	public int yieldTimeMax; // максимальний час появлення астероїдів(спавну)
	private int i;
	
	 void point_spaawn(){
	 float pint = (360)/count_point_spawn;
		float cor = (360)/count_point_spawn;
		for (int j =0; j<count_point_spawn; j++) {
			x=6*Mathf.Cos(cor);
			y=6*Mathf.Sin(cor);
			spawnPoints[j].position= new Vector3(x,y,1);
		
			cor+=pint;
		}
	}

	void Start(){
		point_spaawn();
	}
	void Update() 
	{
		a++;
		if(a==140){
			StartCoroutine(spawn());
			a=0;
			
		}
	}
	
	IEnumerator spawn()
	{
		if (ManagerTime.time_min == 1) {
			amountEnemies=3;
		}
		if (ManagerTime.time_min == 2) {
			amountEnemies=5;
		}
		if (ManagerTime.time_min == 3) {
			amountEnemies=7;
		}
		if (ManagerTime.time_min == 5) {
			amountEnemies=10;
		}
		for (int i = 0; i < amountEnemies; i++)
		{

			if (!Paused.paused)
			{
			GameObject obj = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)]; 
			Transform pos = spawnPoints[Random.Range(0, spawnPoints.Length)]; 
			Instantiate(obj, pos.position, pos.rotation); 

					


			yield return new WaitForSeconds(Random.Range(yieldTimeMin, yieldTimeMax));
		}
		}
	}	
}