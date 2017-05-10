using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScript : MonoBehaviour {

	[SerializeField] private float objectSpeed = 1;
	private float resetPosition = -26.24f;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.left * (objectSpeed * Time.deltaTime));	
		if (transform.localPosition.x <= resetPosition) {
			Vector3 newPos = new Vector3 (72.01f, transform.position.y, transform.position.z);
			transform.position = newPos;
		}
	}
}
