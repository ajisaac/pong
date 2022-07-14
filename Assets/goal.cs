using UnityEngine;

public class goal : MonoBehaviour {
	public bool isPlayerOneGoal;
	private GameManager gm;

	private void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.CompareTag("Ball")) {
			if (!isPlayerOneGoal) {
				Debug.Log("Player One Scored");
				gm.playerOneScored();
			}
			else {
				Debug.Log("Player Two Scored");
				gm.playerTwoScored();
			}
		}
	}

	private void Start() {
		gm = GameObject.Find("GameManager").GetComponent<GameManager>();
	}
}