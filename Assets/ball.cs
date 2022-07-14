using UnityEngine;

public class ball : MonoBehaviour {
	public float speed;
	public Rigidbody2D rb;
	public Vector3 startPosition;

	// Start is called before the first frame update
	void Start() {
		startPosition = transform.position;
		launch();
	}

	void launch() {
		float x = Random.Range(0, 2) == 0 ? -1 : 1;
		float y = Random.Range(0, 2) == 0 ? -1 : 1;
		rb.velocity = new Vector2(speed * x, speed * y);
	}

	// Update is called once per frame
	public void Reset() {
		transform.position = startPosition;
		launch();
	}
}