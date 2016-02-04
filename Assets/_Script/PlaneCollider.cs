using UnityEngine;
using System.Collections;

public class PlaneCollider : MonoBehaviour {

	//Private Instance Variables
	private AudioSource[] _audioSources;
	private AudioSource _islandSound;
	private AudioSource _cloudSound;

	//public Instance variable
	public GameController gameController;


	// Use this for initialization
	void Start () {
		this._audioSources = gameObject.GetComponents<AudioSource> ();
		this._cloudSound = this._audioSources[1];
		this._islandSound = this._audioSources[2];

	}

	// Update is called once per frame
	void Update () {

	}

	public void OnTriggerEnter2D(Collider2D other){

		if (other.gameObject.CompareTag ("Star")) {
			Debug.Log ("Star Collision");
			this._islandSound.Play ();
			this.gameController.ScoreValue += 100;
		}


		if (other.gameObject.CompareTag ("Enemy")) {
			this._cloudSound.Play ();
			this.gameController.LivesValue -= 1;
		}
	}
}
