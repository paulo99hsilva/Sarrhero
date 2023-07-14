using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	int multiplicador = 1;
	int streak = 0;

	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt("Pontos", 0);
		PlayerPrefs.SetInt("Sarrometro", 25);
		PlayerPrefs.SetInt ("Streak", 0);
		PlayerPrefs.SetInt("HighStreak", 0);
		PlayerPrefs.SetInt ("Multi", 1);
		PlayerPrefs.SetInt ("Acertos", 0);
		PlayerPrefs.SetInt ("NumNotas", 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "Nota") {
			PlayerPrefs.SetInt ("NumNotas", PlayerPrefs.GetInt ("NumNotas") + 1);
			ResetStreak ();
		}
	}

	public void AddStreak() {
		streak++;
		multiplicador = (int) (streak / 8) + 1;
		if (multiplicador > 4) {
			multiplicador = 4;
		}
		
		if (PlayerPrefs.GetInt ("Sarrometro") < 50) {
			PlayerPrefs.SetInt ("Sarrometro", PlayerPrefs.GetInt ("Sarrometro") + 1);
		}

		if(streak > PlayerPrefs.GetInt("HighStreak")) {
			PlayerPrefs.SetInt("HighStreak", streak);
		}

		PlayerPrefs.SetInt ("Acertos", PlayerPrefs.GetInt ("Acertos") + 1);
		PlayerPrefs.SetInt ("NumNotas", PlayerPrefs.GetInt ("NumNotas") + 1);

		UpdateGUI ();
	}

	public void ResetStreak() {
		streak = 0;
		multiplicador = 1;
		PlayerPrefs.SetInt ("Sarrometro", PlayerPrefs.GetInt ("Sarrometro") - 2);

		if (PlayerPrefs.GetInt ("Sarrometro") <= 0) {
			Perder ();
		}

		UpdateGUI ();
	}

	public void UpdateGUI() {
		PlayerPrefs.SetInt ("Streak", streak);
		PlayerPrefs.SetInt ("Multi", multiplicador);
	}

	public int GetScore() {
		return 100 * multiplicador;
	}
	
	public void Ganhar() {
		Debug.Log("Ganhou");
		PlayerPrefs.SetString ("Resultado", "Você Sarra!");
		SceneManager.LoadScene ("Final");
	}

	public void Perder() {
		Debug.Log("Perdeu");
		PlayerPrefs.SetString ("Resultado", "Você é um merda!");
		SceneManager.LoadScene ("Final");
	}
}
