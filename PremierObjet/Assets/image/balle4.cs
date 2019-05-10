using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balle4 : MonoBehaviour
{

    public Transform target;

    private Rigidbody2D Rigidbody;

    public float speed = 15f;
    public float rotatespeed = 200f;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        BulletTarget();
    }

    void BulletTarget()
    {
        Vector2 direction = (Vector2)target.position - Rigidbody.position;
        direction.Normalize();

        float rotateAmount = Vector3.Cross(direction, transform.up).z;

        Rigidbody.angularVelocity = -rotateAmount * rotatespeed;

        Rigidbody.velocity = transform.up * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Rigidbody.transform.position = new Vector3(8, -8, 0);
        }
        if (collision.gameObject.tag == "Balle")
        {
            Rigidbody.transform.position = new Vector3(15, 8, 0);
        }
    }
}
