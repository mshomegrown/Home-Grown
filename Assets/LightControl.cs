using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour {
    float moveX;
    float moveZ;
    [SerializeField] float speed = 2f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        moveX = Input.GetAxis("Horizontal");
        moveZ = Input.GetAxis("Vertical");
        transform.position = transform.position + new Vector3(-moveX * speed, 0, -moveZ * speed) * Time.deltaTime;
	}
}
