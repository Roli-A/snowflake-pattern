using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowFall : MonoBehaviour {

	 public float fallSpeed = 0.1f;
	 //public float spinSpeed = 250.0f;

	 // Update is called once per frame
	 void Update () {
		  transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
  //		transform.Rotate(Vector3.forward, spinSpeed * Time.deltaTime);

	 }
}
