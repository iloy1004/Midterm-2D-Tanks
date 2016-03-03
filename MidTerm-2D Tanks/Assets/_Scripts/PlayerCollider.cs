using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour {

    public PlayerController Player;
    private Transform _transform;
    public EnemyController tanks;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Tanks"))
        {
            this.Player.currLives -= 1;
            this.tanks._Reset();
            //this._scream.Play();
            ///this.gameController.LivesValue -= 1;
        }


    }
}
