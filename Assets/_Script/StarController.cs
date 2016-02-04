using UnityEngine;
using System.Collections;

public class StarController : MonoBehaviour {


	public float speed = 5f;

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
		this._currentPosition -= new Vector2(this.speed,0);
		this._transform.position = this._currentPosition;

		if (this._currentPosition.x <= -310) {
			this.Reset ();
		}
	}

	public void Reset(){
		float xPosition = Random.Range (-200f, 200f);
		this._transform.position = new Vector2 (340f,xPosition);
	}
}
