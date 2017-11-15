using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFox : MonoBehaviour {
	
	// Update is called once per frame
	void FixedUpdate () {

        transform.Translate(0, 0, -Time.deltaTime);
        if (transform.position.z > -46)
        {
            Debug.Log("Fox is gone");
            Destroy(gameObject);
        }
	}
}
