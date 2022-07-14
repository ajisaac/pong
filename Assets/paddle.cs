using UnityEngine;

public class paddle : MonoBehaviour {
	public bool isPlayerOne;
	public float speed;
	public Rigidbody2D rigidBody;
	private float movement;

	// Start is called before the first frame update
	void Start() {
	}

	// Update is called once per frame
	void Update() {
		if (isPlayerOne) {
			movement = Input.GetAxisRaw("Vertical");
		}
		else {
			movement = Input.GetAxisRaw("Vertical2");
		}

		rigidBody.velocity = new Vector2(rigidBody.velocity.x, movement * speed);
	}
}