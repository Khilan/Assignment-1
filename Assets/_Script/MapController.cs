using UnityEngine;
using System.Collections;

public class MapController : MonoBehaviour {

	////Public Variables
	public float speed = 3f;


	//Private Variables 
	private Transform _transform;
	private Vector2 _currentPosition;

	// Use this for initialization
	void Start () {
		this._transform = gameObject.GetComponent<Transform> ();

		this.Reset();

	}

	// Update is called once per frame
	void Update () {

		this._currentPosition = this._transform.position;
		this._currentPosition -= new Vector2(this.speed,0);
		this._transform.position = this._currentPosition;

		if (this._currentPosition.x <= -515) {
			this.Reset ();
		}
	}

	//Public Access Methods
	public void Reset(){
		this._transform.position = new Vector2 (515f,0);
	}


}
