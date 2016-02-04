using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {


	//Private Instance Variables
	private int _scoreValue;
	private int _livesValue;



	//public Access methods
	public int ScoreValue{
		get{
			return _scoreValue;
		}	

		set{
			this._scoreValue = value;
			this.ScoreLabel.text = "Score: " + this._scoreValue;
		}
	}

	public int LivesValue{
		get{
			return _livesValue;
		}	

		set{
			this._livesValue = value;
			if (this._livesValue <= 0) {
				this._endGame ();
			} else {
				this.LivesLabel.text = "Lives: " + this._livesValue; 
			}
		}
	}

	//Public Instance Variable
	public int EnemyNumber = 4;
	public EnemyController enemy;
	public PlaneController plane;
	public StarController star;
	public Text LivesLabel;
	public Text ScoreLabel;
	public Text GameOverLabel;
	public Text HighScoreLabel;
	public Button RestartButton;



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
		this.ScoreValue = 0;
		this.LivesValue = 5;
		this.GameOverLabel.enabled = false;
		this.HighScoreLabel.enabled = false;
		this.RestartButton.gameObject.SetActive (false);

		for (int EnemyCount = 0; EnemyCount < this.EnemyNumber; EnemyCount++) {
			Instantiate (enemy.gameObject);
		}
	}

	private void _endGame(){
		this.HighScoreLabel.text = "High Score: " + this._scoreValue;
		this.RestartButton.gameObject.SetActive (true);
		this.GameOverLabel.enabled = true;
		this.plane.gameObject.SetActive (false);
		this.star.gameObject.SetActive (false);
		this.LivesLabel.enabled = false;
		this.ScoreLabel.enabled = false;
		this.HighScoreLabel.enabled = true;


	}

	public void RestartButtonClick(){
		Application.LoadLevel ("Main");
	}
}
