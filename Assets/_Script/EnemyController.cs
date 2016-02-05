using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	//Public Variables
	public float minVericalSpeed = 6f;
	public float maxVericalSpeed = 8f;
	public float minHorizontalSpeed = -2f;
	public float maxHorizontalSpeed = 2f;


	//Private Variables
	private Transform _transform;
	private Vector2 _currentPosition;
	private float _verticalSpeed;
	private float _horizonalDrift;

	// Use this for initialization
	void Start () {
		//Make a reference of Transform components
		this._transform = gameObject.GetComponent<Transform> ();
		this.Reset();
	}

	// Update is called once per frame
	void Update () {
		this._currentPosition = this._transform.position;
		this._currentPosition -= new Vector2(this._verticalSpeed,this._horizonalDrift);
		this._transform.position = this._currentPosition;

		if (this._currentPosition.x <= -350) {
			this.Reset ();
		}
	}

	//Public Access Methods
	public void Reset(){
		this._verticalSpeed = Random.Range (this.minVericalSpeed, this.maxVericalSpeed);
		this._horizonalDrift = Random.Range (this.minHorizontalSpeed, this.maxHorizontalSpeed);
		float xPosition = Random.Range (-200f, 200f);
		this._transform.position = new Vector2 (345f,xPosition);
	}
}
