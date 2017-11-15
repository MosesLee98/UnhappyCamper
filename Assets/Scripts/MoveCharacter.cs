using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveCharacter : MonoBehaviour {

    public Text restart;

    public Vector3 RotateAmount; 

    private void Start()
    {
        restart.GetComponent<Text>().enabled = false;
    }

    // Update is called once per frame
    void FixedUpdate () {
        RotateAmount = new Vector3(Input.acceleration.x /2.2f, 0, 0);
        transform.Translate(RotateAmount);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Rock")
        {
            gameObject.GetComponent<ParticleSystem>().Play();
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            Destroy(gameObject, 0.3f);
            restart.GetComponent<Text>().enabled = true;
            
        }
    }

}
