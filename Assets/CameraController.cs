﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject followTarget;
    private Vector3 targetPostion;
    public float moveSpeed;
	
	void Start () {
		
	}
	
	
	void Update ()
    {
        targetPostion = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPostion, moveSpeed * Time.deltaTime);

	}
}
