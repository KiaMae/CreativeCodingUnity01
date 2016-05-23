﻿using UnityEngine;
using System.Collections;

public class Sketch : MonoBehaviour {
	public GameObject myPrefab;

	void Start () {
		
		int totalCubes = 8;
		float totalDistance = 3.0f;
	
	//Sin Distro
		for (int i = 0; i < totalCubes; i++)
		{
			float perc = i / (float)totalCubes;
			float sin = Mathf.Sin (perc * Mathf.PI/2);

			float x = 2.0f + sin * totalDistance;
			float y = 5.0f;
			float z = 0.0f;

			var newCube = (GameObject)Instantiate (myPrefab, new Vector3 (x, y, z), Quaternion.identity);
			newCube.GetComponent<CubeScript>().SetSize(.5f*(1.0f - perc));	
			newCube.GetComponent<CubeScript> ().rotateSpeed = .2f + perc;
		}
	}
	void Update () {
	
	}
}
