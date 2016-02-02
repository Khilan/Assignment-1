using UnityEngine;
using System.Collections;

public class StoneController : MonoBehaviour {

	public float minVericalSpeed = 6f;
	public float maxVericalSpeed = 8f;
	public float minHorizontalSpeed = -2f;
	public float maxHorizontalSpeed = 2f;



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
		this._currentPosition -= new Vector2(this._horizonalDrift, this._verticalSpeed);
		this._transform.position = this._currentPosition;

		if (this._currentPosition.y <= -196) {
			this.Reset ();
		}
	}

	public void Reset(){
		this._verticalSpeed = Random.Range (this.minVericalSpeed, this.maxVericalSpeed);
		this._horizonalDrift = Random.Range (this.minHorizontalSpeed, this.maxHorizontalSpeed);
		float xPosition = Random.Range (-210f, 210f);
		this._transform.position = new Vector2 (xPosition, 192f);
	}
}
