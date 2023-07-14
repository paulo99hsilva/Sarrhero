using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sarrometro : MonoBehaviour {
	int sarrometro;
	GameObject agulha;

	// Use this for initialization
	void Start () {
		agulha = transform.Find ("Agulha").gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		sarrometro = PlayerPrefs.GetInt ("Sarrometro");
		agulha.transform.localPosition = new Vector2 ((float) ((sarrometro * 0.06) - 52.5), (float) -264.88);
	}
}
