using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coeur : MonoBehaviour {

    private Rigidbody2D Rigidbody;

    // Use this for initialization
    void Start () {
        Rigidbody = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Balle")
        {
            Rigidbody.transform.position = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), 0);
        }
    }
}
