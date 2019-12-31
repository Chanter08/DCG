
using UnityEngine;
using System.Collections;

public class Player2 : MonoBehaviour {
	
	float y = -1;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//if key pressed is 'up arrow' paddle will go up
		if (Input.GetKey (KeyCode.UpArrow)) {

			//amount the paddle will go up
			y += 0.1f;
		}

		//if key pressed is 'down arrow' paddle will go down
		if (Input.GetKey (KeyCode.DownArrow)) {

			//amount the paddle will go down
			y -= 0.1f;
		}

		//Integers in the mathf.clamp are the highest and lowest point the paddle can go
		transform.position = new Vector3 (transform.position.x,Mathf.Clamp(y, -3.78f,2.61f), transform.position.z);

		//when one of the players reaches 3 goals the paddle will be taken to the specified position
		if (Ball.player1 == 3 || Ball.player2 == 3) {
			
			transform.position = new Vector3(11.38f,-0.75f,0);
		}
	}
}