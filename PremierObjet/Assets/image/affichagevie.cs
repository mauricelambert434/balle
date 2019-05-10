using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class affichagevie : MonoBehaviour {

    public Text vie;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        string Vie = "vie : " + GameObject.Find("character-wallpaper-2").GetComponent<perso>().Vie.ToString();
        vie.text = Vie;
	}
}
