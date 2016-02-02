using UnityEngine;
using System.Collections;

public class StarController : MonoBehaviour {


	public float speed = 4f;

	private Transform _transform;
	private Vector2 _currentPosition;

	// Use this for initialization
	void Start () {
		//Make a reference of Transform components
		this._transform = gameObject.GetComponent<Transform> ();

		this.Reset();

	}

	// Update is called once per frame
	void Update () {
		this._currentPosition = this._transform.position;
		this._currentPosition -= new Vector2(0, this.speed);
		this._transform.position = this._currentPosition;

		if (this._currentPosition.y <= -184) {
			this.Reset ();
		}
	}

	public void Reset(){
		float xPosition = Random.Range (-210f, 210f);
		this._transform.position = new Vector2 (xPosition, 192f);
	}
}
