using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerForTeamworks : MonoBehaviour {


    public int numberOfSnowflakes = 0;

    private Vector3 userPosition;
    private Vector3 pastPosition;
    public float speed = 0.5f;
    private List<GameObject> allFlakes = new List<GameObject>();

    private void Start()
    {
		numberOfSnowflakes = getCurrentSnowflakeCountOnField();
    }

    private void Update()
    {

       // Camera.main.transform.parent.transform.position += (Camera.main.transform.forward * Time.deltaTime *speed);
        //Translate(new Vector3(0, 0, Time.deltaTime * speed), Space.World);

        destroyflakesPastUser();
		numberOfSnowflakes = getCurrentSnowflakeCountOnField();
    }


    private void destroyflakesPastUser() {
		List<GameObject> objectsToDestroy = new List<GameObject>();
        // Any flake at a point on Z axis behind the Camera would be destroyed
		foreach (GameObject a in allFlakes.ToArray()) {
			
            if (a!=null &&(a.transform.position.y < Camera.main.transform.parent.transform.position.y)) {                
            	objectsToDestroy.Add(a);				
				Debug.Log("Marked for destruction: "+a);
				allFlakes.Remove(a);

            }
        }
		foreach (GameObject a in objectsToDestroy.ToArray()) {            					
			Debug.Log("Destroying  "+a);
				Destroy(a);
        }
    }
 
    public void incrementflakeCount() {
		numberOfSnowflakes++;
    }

    public int getflakeCount() {
		return numberOfSnowflakes;
    }

    public int getCurrentSnowflakeCountOnField()
    {        
		allFlakes = GameObject.FindGameObjectsWithTag("Snowflake").ToList<GameObject>(); ;
		return allFlakes.Count; 
    }
 }
