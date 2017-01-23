using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitSelf : MonoBehaviour {
    public float orbitSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, orbitSpeed * Time.deltaTime, 0);
    }
}