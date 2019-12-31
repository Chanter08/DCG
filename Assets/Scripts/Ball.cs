
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Ball : MonoBehaviour {
	
	public float speed = 10; //speed of the ball

	public AudioClip goal;
	public AudioClip paddle;
	public AudioClip wall;
	public AudioClip won;

	public static int player1;
	public static int player2;

	public static bool Haswon1 = false;
	public static bool Haswon2 = false;

	// Use this for initialization
	void Start () {

			GetComponent<Rigidbody2D>().velocity = Vector2.one * speed; //sends ball in the right direction

	}
	
	// Update is called once per frame
	void Update () {

		// if player 1 scores 3 the ball will taken in the position stated
		if (player1 == 3) {
			Haswon1 = true; 
			GetComponent<AudioSource>().PlayOneShot(won);
			transform.position = new Vector3 (0, -0.75f, 0);


		} 

		// if player 2 scores 3 the ball will taken in the position stated
		else if (player2 == 3) {
			Haswon2 = true;
			GetComponent<AudioSource>().PlayOneShot(won);
			transform.position = new Vector3 (0, -0.75f, 0);
		}
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		//If ball hits the right wall player ones score will increase by 1
		if (col.gameObject.name == "RightWall") {

			player1 += 1;
			//plays audioclip loaded in goal
			GetComponent<AudioSource>().PlayOneShot(goal);

			//puts ball in position stated
			this.transform.position = new Vector3 (0, -0.75f, 0);


		GetComponent<Rigidbody2D>().velocity = new Vector3(1,1,0) * speed;
		


		}
		//If ball hits the left wall player ones score will increase by 1
		if (col.gameObject.name == "LeftWall") {
			player2 += 1;

			//plays audioclip loaded in goal
			GetComponent<AudioSource>().PlayOneShot(goal);

			this.transform.position = new Vector3 (0, -0.75f, 0);

				GetComponent<Rigidbody2D>().velocity = new Vector3(-1,1,0) * speed;

		}

		if (col.gameObject.name == "Player1") {
		
			//plays audioclip loaded in paddle when ball collides with paddle
			GetComponent<AudioSource>().PlayOneShot(paddle);
		}

		if (col.gameObject.name == "Player2") {

			//plays audioclip loaded in paddle when ball collides with paddle
			GetComponent<AudioSource>().PlayOneShot(paddle);
		}

		if (col.gameObject.name == "TopWall") {

			//plays audioclip loaded in wall when ball collides with wall
			GetComponent<AudioSource>().PlayOneShot(wall);
		}

		if (col.gameObject.name == "BottomWall") {

			//plays audioclip loaded in wall when ball collides with wall
			GetComponent<AudioSource>().PlayOneShot(wall);
		}

	}

}
