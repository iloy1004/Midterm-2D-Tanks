using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++
	public float speed;
	public Boundary boundary;
    public int Lives;
    public int currLives;
    public int Scores;
    public Text ScoreLabel;

    //Game over UI
    public GameObject GameoverUI;

    // get a reference to the camera to make mouse input work
    public Camera camera; 
	
	// PRIVATE INSTANCE VARIABLES
	private Vector2 _newPosition = new Vector2(0.0f, 0.0f);


	// Use this for initialization
	void Start () {
        this.currLives = Lives;
	}

	// Update is called once per frame
	void Update () {
		this._CheckInput ();

        if (this.currLives > this.Lives)
        {
            this.currLives = this.Lives;
        }

        if (this.currLives <= 0)
        {
            Die();
        }

    }

	private void _CheckInput() {
		this._newPosition = gameObject.GetComponent<Transform> ().position; // current position

		/* movement by keyboard
		if (Input.GetAxis ("Horizontal") > 0) {
			this._newPosition.x += this.speed; // add move value to current position
		}
	
		
		if (Input.GetAxis ("Horizontal") < 0) {
			this._newPosition.x -= this.speed; // subtract move value to current position
		}
		*/

		// movement by mouse
		Vector2 mousePosition = Input.mousePosition;
		this._newPosition.x = this.camera.ScreenToWorldPoint (mousePosition).x;

		this._BoundaryCheck ();

		gameObject.GetComponent<Transform>().position = this._newPosition;
	}

	private void _BoundaryCheck() {
		if (this._newPosition.x < this.boundary.xMin) {
			this._newPosition.x = this.boundary.xMin;
		}

		if (this._newPosition.x > this.boundary.xMax) {
			this._newPosition.x = this.boundary.xMax;
		}
	}

    void Die()
    {

        this.GameoverUI.SetActive(true);
        this.ScoreLabel.text = "Score: " + this.Scores;
        this.ScoreLabel.enabled = true;
    }
}
