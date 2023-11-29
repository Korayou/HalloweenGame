using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {

    private float y = 0.0f;
	[SerializeField] private float rotation = 0.05f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.localRotation = Quaternion.Euler(0, y, 0);
        y += rotation;
        

    }
}
