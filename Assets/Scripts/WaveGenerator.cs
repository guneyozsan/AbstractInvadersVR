using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveGenerator : MonoBehaviour {

    public GameObject wavePiecePrefab;
    public GameObject waveStartPoint;
    float lifeTime = 5;

	// Use this for initialization
	void Start () {
        InvokeRepeating("GenerateWave", 0, 0.02f);
	}
	
	// Update is called once per frame
	void Update () {

    }

    void GenerateWave () {
        GameObject wavePiece = Instantiate(wavePiecePrefab, waveStartPoint.transform.position, Quaternion.identity) as GameObject;
        wavePiece.GetComponent<Rigidbody>().AddForce(transform.forward * 1000 * wavePiece.GetComponent<Rigidbody>().mass);
        Destroy(wavePiece, lifeTime);
    }
}
