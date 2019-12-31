using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public GUISkin score1, score2, haswon1, haswon2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){

		GUI.skin = score1;
		//label will hold player ones score
		GUI.Label(new Rect (190, 20, 100, 100), "Player 1: " + Ball.player1);
		
		GUI.skin = score2;
		//label will hold player twos score
		GUI.Label (new Rect (520, 20, 120, 100), "Player 2: " + Ball.player2);


		if (Ball.Haswon1 == true) {

			GUI.skin = haswon1;
			//if player one reaches 3 goals first this label will be displayed on screen
			GUI.Label (new Rect (250, 175, 150, 50), "Player 1 Wins!");
		}
		
		if (Ball.Haswon2 == true) {
			GUI.skin = haswon2;
			//if player two reaches 3 goals first this label will be displayed on screen
			GUI.Label (new Rect (550, 175, 150, 50), "Player 2 Wins!");
		}
	}
}
