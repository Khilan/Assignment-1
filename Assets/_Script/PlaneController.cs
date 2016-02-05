using UnityEngine;
using System.Collections;

public class PlaneController : MonoBehaviour {

	//public Variable
	public float speed = 5f;

	//Private Instance Variabel
	private float _playerInput;
	private float _playerInputVertical;
	private Transform _transform;
	private Vector2 _currentPosition;


	// Use this for initialization
	void Start () {
		this._transform = gameObject.GetComponent<Transform> ();
	}

	// Update is called once per frame
	void Update () {
		this._currentPosition = this._transform.position;

		this._playerInput = Input.GetAxis ("Horizontal");
		this._playerInputVertical = Input.GetAxis ("Vertical");

		if (this._playerInputVertical > 0) {
			this._currentPosition += new Vector2 (0,this.speed);
		}
		if (this._playerInputVertical < 0) {
			this._currentPosition -= new Vector2 (0,this.speed);
		}
		if (this._playerInput > 0) {
			this._currentPosition += new Vector2 (this.speed,0);
		}
		if (this._playerInput < 0) {
			this._currentPosition -= new Vector2 (this.speed,0);
		}
		this._checkBounds ();

		this._transform.position = this._currentPosition;

	}


	//Private Access Methods
	//Checks the Boundary
	private void _checkBounds(){
		if (this._currentPosition.x >= 270) {
			this._currentPosition.x = 270;
		}
		if (this._currentPosition.x <= -275) {
			this._currentPosition.x = -275;
		}
		if (this._currentPosition.y >= 189) {
			this._currentPosition.y = 189;
		}
		if (this._currentPosition.y <= -189) {
			this._currentPosition.y = -189;
		}
	}
}
