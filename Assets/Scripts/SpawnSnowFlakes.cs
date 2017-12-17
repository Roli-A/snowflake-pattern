using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSnowFlakes : MonoBehaviour {

	 public GameObject snowFlake;  // SnowFlake Object in Scene
	 public float spawnTime;       // How long between each spawn.
	 private float timer;          // counting timer, reset after calling SpawnRandom() function
	 private int randomNumber;     // variable for storage of an random Number


	 // Update is called once per frame
	 void Update () {
		  timer += Time.deltaTime; // Timer Counter
		  if(timer>spawnTime){
			   SpawnRandom();         //Calling method SpawnRandom()
			   timer = 0;             //Reseting timer to 0
		  }
	 }

	 public void SpawnRandom()
	 {
		float screenX = Random.Range(Camera.main.transform.parent.transform.position.x-5,Camera.main.transform.parent.transform.position.x+5);//Screen.width);
		  float screenY = 100;//Screen.height;
		  float ScreenZ = Random.Range(Camera.main.farClipPlane/2, Camera.main.farClipPlane);

		  //Creating random Vector3 position
		Vector3 screenPosition = new Vector3(screenX, screenY, ScreenZ);//Camera.main.ScreenToWorldPoint(new Vector3(screenX, screenY, ScreenZ));

		  //Instantiation of the Snowflake Object
		  Instantiate(snowFlake,screenPosition,Quaternion.Euler(new Vector3(0, 90, 90)));
	 }
}
