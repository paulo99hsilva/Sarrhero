using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VoltarScript : MonoBehaviour {
	public KeyCode tecla_start;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (tecla_start)) {
			SceneManager.LoadScene ("MenuPrincipal");
		}
	}
}
