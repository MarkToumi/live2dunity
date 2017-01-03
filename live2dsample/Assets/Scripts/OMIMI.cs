using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OMIMI : MonoBehaviour {
	public GameObject camera;
	public float speed;
	public AudioClip[] songs;
	private AudioSource audio;
	private int count;
	// Use this for initialization
	void Start () {
		count = 0;
		audio = GetComponent<AudioSource> ();
		audio.clip = songs [0];
		audio.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround (camera.transform.position, Vector3.up, speed);
		if (!audio.isPlaying) {
			if (songs.Length == count - 1)
				count = 0;
			else count++;
			audio.clip = songs [count];
			audio.Play ();
		}
	}
}
