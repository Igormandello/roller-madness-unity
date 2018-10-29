using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFollow : MonoBehaviour {

    private GameObject player, ground;
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        ground = GameObject.Find("Ground");
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.RotateAround(Vector3.zero, Vector3.up, 2);
        this.transform.LookAt(Vector3.zero);
	}
}
