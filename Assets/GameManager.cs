using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour {
	[Header("Ball")]
	public GameObject ball;

	[Header("Player One")]
	public GameObject p1Paddle;
	public GameObject p1Goal;

	[Header("Player Two")]
	public GameObject p2Paddle;
	public GameObject p2Goal;

	[Header("Score UI")]
	public GameObject p1Text;
	public GameObject p2Text;

	private int p1Score;
	private int p2Score;

	public void playerOneScored() {
		p1Score++;
		string score = p1Score.ToString();
		if (p1Score < 10)
			score = "0" + score;
		p1Text.GetComponent<TextMeshPro>().text = score;
		reset();
	}

	public void playerTwoScored() {
		p2Score++;
		string score = p2Score.ToString();
		if (p2Score < 10)
			score = "0" + score;
		p2Text.GetComponent<TextMeshPro>().text = score;
		reset();
	}

	void reset() {
		ball.GetComponent<ball>().Reset();
	}
}