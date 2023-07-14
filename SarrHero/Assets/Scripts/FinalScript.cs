using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalScript : MonoBehaviour {
	public KeyCode tecla_a;
	public KeyCode tecla_b;
	public KeyCode tecla_start;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (tecla_a)) {
			SceneManager.LoadScene ("Selecao");
		} else if (Input.GetKeyDown (tecla_b)) {
			SceneManager.LoadScene (PlayerPrefs.GetString ("Musica"));
		} else if (Input.GetKeyDown (tecla_start)) {
			SceneManager.LoadScene ("MenuPrincipal");
		}
	}
}
