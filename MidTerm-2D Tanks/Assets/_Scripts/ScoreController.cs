using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

    public Text Score;
    public Text Lives;
    public PlayerController _Player;

    //Declare private variables
    private string _txtScore;
    private string _txtLives;

    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        this.DrawHUD(this._Player.currLives);
        this.DrawScore(this._Player.Scores);
    }

    void DrawScore(int curScore)
    {
        this._txtScore = "Score: " + curScore;
        this.Score.text = this._txtScore;
    }

    void DrawHUD(int curLives)
    {
        this._txtLives = "Lives: " + curLives;
        this.Lives.text = this._txtLives;
    }
}
