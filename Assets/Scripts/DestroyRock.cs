using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyRock : MonoBehaviour {

    private Generator generator;

    private void Start()
    {
        GameObject genObj = GameObject.FindWithTag("Generator");
        if (genObj != null)
        {
            generator = genObj.GetComponent<Generator>();
        }
        if (genObj == null)
        {
            Debug.Log("Connot find Generator script");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        gameObject.GetComponent<ParticleSystem>().Play();
        generator.AddScore(1);
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        Destroy(gameObject, 0.3f);

    }

    
}
