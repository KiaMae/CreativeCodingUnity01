using UnityEngine;
using System.Collections;

public class CubeScript : MonoBehaviour {

	public float rotateSpeed = 1.0f;
	public Vector3 spinSpeed = new Vector3(0,0,0);
	public Vector3 spinAxis = new Vector3 (0, 1, 0);
	// Use this for initialization
	void Start () {
		spinSpeed = new Vector3 (Random.value, Random.value, Random.value);
		spinAxis = Vector3.up;
		spinAxis.x = (Random.value - Random.value * .1f);
	public void SetSize(float size)
		this.transform.Rotate(spinSpeed);
