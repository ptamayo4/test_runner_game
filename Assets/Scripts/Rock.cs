﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : ObjectScript {

	[SerializeField] Vector3 topPosition;
	[SerializeField] Vector3 bottomPosition;
	[SerializeField] float rockSpeed;

	// Use this for initialization
	void Start () {
		StartCoroutine (Move (bottomPosition));
	}

	protected override void Update(){
		base.Update ();
	}

	IEnumerator Move(Vector3 target){
		while (Mathf.Abs((target - transform.localPosition).y) > 0.20f) {
			Vector3 direction = target.y == topPosition.y ? Vector3.up : Vector3.down;
			transform.localPosition += direction * Time.deltaTime* rockSpeed;
			yield return null;
		}
		print ("Reached the target");
		yield return new WaitForSeconds (0.5f);

		Vector3 newTarget = target.y == topPosition.y ? bottomPosition : topPosition;
		StartCoroutine (Move (newTarget));
	}
}
