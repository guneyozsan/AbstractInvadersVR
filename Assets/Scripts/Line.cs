using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour {

    public GameObject[] point;

    Vector3[] linePosition;

	// Use this for initialization
	void Start () {
        linePosition = new Vector3[point.Length];
	}
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < point.Length; i++)
        {
            linePosition[i] = point[i].transform.position;
        }

        transform.GetComponent<LineRenderer>().SetPositions(linePosition);
        //Debug.Log(transform.GetComponent<LineRenderer>().GetPositions());
	}
}
