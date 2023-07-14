using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour {

	public string name;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (this.gameObject.tag == "Mensagem") {
			GetComponent<Text> ().text = PlayerPrefs.GetString (name);
		} else {
			GetComponent<Text> ().text = PlayerPrefs.GetInt (name) + "";
		}
	}
}
