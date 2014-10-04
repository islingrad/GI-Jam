using UnityEngine;
using System.Collections;

public class TimerScript : MonoBehaviour {
	public float Interval;
	
	float timer;
	int mode;

	public int Mode {
		get { return mode; }
	}

	// Use this for initialization
	void Start () {
		mode = 0;
		timer = Interval;
	}
	
	// Update is called once per frame
	void Update () {
		if (timer <= 0) {
			timer = Interval;
			switchMode();
		}
	
		timer -= Time.deltaTime;
	}
	
	void switchMode() {
		if (mode == 0) {
			mode = 1;
		}
		else {
			mode = 0;
		}
	}
}
