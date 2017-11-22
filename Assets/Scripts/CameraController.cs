using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform target;
    public float distance = -1f;
    public float lift = 5f;
	
	// Update is called once per frame
	void Update () {
        transform.position = target.position + new Vector3 (0, lift, distance);
	}
}
