using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour {
	public KeyCode tecla_a;
	public KeyCode tecla_b;
	public KeyCode tecla_x;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (tecla_a)) {
			SceneManager.LoadScene ("Selecao");
		} else if (Input.GetKeyDown (tecla_b)) {
			Debug.Log ("Apertou B");
			SceneManager.LoadScene ("Controles");
		} else if (Input.GetKeyDown (tecla_x)) {
			Debug.Log ("Apertou X");
			SceneManager.LoadScene ("Creditos");
		}
	}
}
