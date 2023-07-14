using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nota : MonoBehaviour {
	Rigidbody2D rb;
	public float velocidade;

	void Awake() {
		rb = GetComponent<Rigidbody2D> ();
	}

	// Use this for initialization
	void Start () {
		rb.velocity = new Vector2 (0, -velocidade);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
