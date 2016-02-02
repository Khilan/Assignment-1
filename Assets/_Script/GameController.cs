using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	//Public Instance Variable
	public int StoneNumber = 3;
	public StoneController stone;


	// Use this for initialization
	void Start () {
		this._initialize ();

	}

	// Update is called once per frame
	void Update () {

	}

	//Private Methods ++++++++++++++++++++++++++
	private void _initialize()
	{
		for (int StoneCount = 0; StoneCount < this.StoneNumber; StoneCount++) {
			Instantiate (stone.gameObject);
		}
	}
}
