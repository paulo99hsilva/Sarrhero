using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour {

	SpriteRenderer sr;
	public KeyCode tecla;
	bool ativado = false;
	GameObject nota, GameManager, foguinho;
	Color old;
	public bool createMode;
	public GameObject n;
	float lastInput = 0.0f;

	// Use this for initialization
	void Awake () {
		sr = GetComponent<SpriteRenderer> ();
	}

	void Start() {
		GameManager = GameObject.Find("GameManager");
		old = sr.color;
	}
	
	// Update is called once per frame
	void Update () {
		if (createMode) {
			if (this.gameObject.name == "Verde") {
				if (Input.GetAxis ("Verde") == 1 && lastInput <= 0) {
					Instantiate (n, transform.position, Quaternion.identity);
				}

				lastInput = Input.GetAxis ("Verde");
			} else if (this.gameObject.name == "Amarelo") {
				if (Input.GetAxis ("Amarelo") == 1 && lastInput <= 0) {
					Instantiate (n, transform.position, Quaternion.identity);
				}

				lastInput = Input.GetAxis ("Amarelo");
			} else {
				if (Input.GetKeyDown (tecla)) {
					Instantiate (n, transform.position, Quaternion.identity);
				}
			}
		} else {
			if (this.gameObject.name == "Verde") {
				if (Input.GetAxis ("Verde") == 1 && lastInput <= 0) {
					if (ativado) {
						StartCoroutine (Apertar (true));
						Destroy (nota);
						GameManager.GetComponent<GameManager> ().AddStreak ();
						Pontuar ();
					} else {
						StartCoroutine (Apertar (false));
						GameManager.GetComponent<GameManager>().ResetStreak();
					}
				}

				lastInput = Input.GetAxis ("Verde");
			} else if (this.gameObject.name == "Amarelo") {
				if (Input.GetAxis ("Amarelo") == 1 && lastInput <= 0) {
					if (ativado) {
						StartCoroutine (Apertar (true));
						Destroy (nota);
						GameManager.GetComponent<GameManager> ().AddStreak ();
						Pontuar ();
					} else {
						StartCoroutine (Apertar (false));
						GameManager.GetComponent<GameManager>().ResetStreak();
					}
				}

				lastInput = Input.GetAxis ("Amarelo");
			} else {
				if (Input.GetKeyDown (tecla)) {
					if (ativado) {
						StartCoroutine(Apertar (true));
						Destroy (nota);
						GameManager.GetComponent<GameManager> ().AddStreak ();
						Pontuar ();
					} else {
						StartCoroutine(Apertar (false));
						GameManager.GetComponent<GameManager>().ResetStreak();
					}
				}
			}
		}
	}

	void OnTriggerEnter2D(Collider2D col) {

		if (col.gameObject.tag == "Nota") {
			ativado = true;
			nota = col.gameObject;
		} else if (col.gameObject.tag == "Vitoria") {
			GameManager.GetComponent<GameManager> ().Ganhar ();
		}
	}

	void OnTriggerExit2D(Collider2D col) {
		ativado = false;
	}

	void Pontuar() {
		PlayerPrefs.SetInt ("Pontos", PlayerPrefs.GetInt ("Pontos") + GameManager.GetComponent<GameManager>().GetScore());
	}

	IEnumerator Apertar(bool acertou) {
		sr.color = new Color (0, 0, 0);
		foguinho = this.transform.Find ("Foguinho").gameObject;

		if (acertou) {
			foguinho.SetActive (true);
		}

		yield return new WaitForSeconds (0.2f);
		foguinho.SetActive (false);
		sr.color = old;
	}
}
