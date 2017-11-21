using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour {
    string inputButtonName = "Pull";
    public GameObject ball;
    public float Force = 5;
    bool Play = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
            if (Input.GetButtonDown(inputButtonName) && Play ) {
            ball.GetComponent<Collider>().GetComponent<Rigidbody>().AddForce(Force * Vector3.left);

            }
        }
}
