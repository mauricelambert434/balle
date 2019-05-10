using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class perso : MonoBehaviour {

    private Rigidbody2D rb2d;
    private float offX, offY;
    public float speed;
    public int Vie = 10;
    public float tempsDebut;
    public float tempsFin;
    public float tempsTotale;
    Vector2 mvt = new Vector2();
    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        tempsDebut = Time.time;
    }
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            mvt = Vector2.up;
            rb2d.AddForce(mvt * 1000);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            mvt = Vector2.down;
            rb2d.AddForce(mvt * 1000);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            mvt = Vector2.right;
            rb2d.AddForce(mvt * 25);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            mvt = Vector2.left;
            rb2d.AddForce(mvt * 25);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Balle")
        {
            Vie = Vie - 1;
            if (Vie == 0)
            {
                tempsFin = Time.time;
                tempsTotale = tempsFin - tempsDebut;
                Application.LoadLevel(0);
            }
        }
        if (collision.gameObject.tag == "Bonus")
        {
            Vie += 1;
        }
    }
}