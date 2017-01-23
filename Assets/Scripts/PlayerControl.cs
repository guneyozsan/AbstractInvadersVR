using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    Transform transformInSight;
    public GameObject crossHair;
    public Transform target;
    LayerMask layerMask = 1 << 5;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        //Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));

        if (Physics.Linecast(transform.position, target.position, out hit, layerMask))
        {
            //transformInSight = hit.collider.transform;    
            crossHair.transform.position = new Vector3(hit.point.x, hit.point.y, crossHair.transform.position.z);
        }
    }
}