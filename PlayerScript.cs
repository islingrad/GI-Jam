using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	public KeyCode MoveUp;
	public KeyCode MoveDown;
	public KeyCode MoveLeft;
	public KeyCode MoveRight;
	public float Speed;
	public Color ColorMe;
	public Color ColorOther;

	public GameObject me;
	public GameObject other;

	
	int mode;
	TimerScript timer;
	int score;

	// Use this for initialization
	void Start () {
		timer = GameObject.Find ("Timer").GetComponent<TimerScript>();
		ColorMe = Color.red;
		ColorOther = Color.blue;
		GameObject.Find ("EntityX").GetComponent<SpriteRenderer>().color = ColorMe;
		GameObject.Find ("EntityY").GetComponent<SpriteRenderer>().color = ColorOther;
		mode = timer.Mode;
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(MoveUp)) {
			me.rigidbody2D.AddForce(new Vector2(0, 1) * Speed);
		}
		else if (Input.GetKey(MoveDown)) {
			me.rigidbody2D.AddForce(new Vector2(0, 1) * -Speed);
		}
		
		if (Input.GetKey (MoveLeft)) {
			me.rigidbody2D.AddForce(new Vector2(1, 0) * -Speed);
		}
		else if (Input.GetKey(MoveRight)) {
			me.rigidbody2D.AddForce(new Vector2(1, 0) * Speed);
		}
		
		if (timer.Mode != mode) {
			// swap entities
			GameObject temp = me;
			me = other;
			other = temp;
			// new mode
			mode = timer.Mode;
			// swap colors
			swap_player();
		}
		GameObject.Find ("EntityX").GetComponent<SpriteRenderer>().color = ColorMe;
		GameObject.Find ("EntityY").GetComponent<SpriteRenderer>().color = ColorOther;
	}
	void swap_player(){
		Color temp_color = ColorMe;
		ColorMe = ColorOther;
		ColorOther = temp_color;

		}
}
