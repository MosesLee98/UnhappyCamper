using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBird : MonoBehaviour {

    int counter = 0;

    // Update is called once per frame
    void FixedUpdate() {

        if (counter == 0) {
            transform.Translate(0, 0, Time.deltaTime * 2);
            if (transform.position.x < -47)
            {
                counter = 1;
            }
        }

        while (counter == 1)
        {
            transform.Translate(0, 0, -Time.deltaTime * 2);
            if (transform.position.x > -11)
            {
                counter = 0;
            }
        }
    }
}
