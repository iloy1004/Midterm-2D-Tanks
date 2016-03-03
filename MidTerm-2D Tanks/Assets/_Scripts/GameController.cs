using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	public int tankCount;
	public EnemyController tank;
    public PlayerController player;


    // Use this for initialization
    void Start () {
		this._GenerateTanks ();
	}
	
	// Update is called once per frame
	void Update () {
	    if(player.currLives <=0)
        {
            this.player.gameObject.SetActive(false);
            this.tank.gameObject.SetActive(false);
        }
       
	}

	// generate Clouds
	private void _GenerateTanks() {
		for (int count=0; count < this.tankCount; count++) {
			Instantiate(tank);
		}
	}

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

}
