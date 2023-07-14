using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelecaoScript : MonoBehaviour {
	public KeyCode tecla_a;
	public KeyCode tecla_b;
	public KeyCode tecla_x;
	public KeyCode tecla_y;
	public KeyCode tecla_start;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (tecla_a)) {
			SceneManager.LoadScene ("TecladoLindinho");
			PlayerPrefs.SetString ("Musica", "TecladoLindinho");
		} else if (Input.GetKeyDown (tecla_b)) {
			SceneManager.LoadScene ("Gas");
			PlayerPrefs.SetString ("Musica", "Gas");
		} else if (Input.GetKeyDown (tecla_x)) {
			SceneManager.LoadScene ("Roca");
			PlayerPrefs.SetString ("Musica", "Roca");
		} else if (Input.GetKeyDown (tecla_y)) {
			SceneManager.LoadScene ("Toma");
			PlayerPrefs.SetString ("Musica", "Toma");
		} else if (Input.GetKeyDown (tecla_start)) {
			SceneManager.LoadScene ("MenuPrincipal");
		}
	}
}
