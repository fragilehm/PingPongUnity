using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	public float InputForceScale = 20f;
	public float InitialAngle = 45;

	public AudioClip WallSound;
	public AudioClip PaddleSound;
	private AudioSource audioSource;
	private Rigidbody rigidBody;

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody> ();

		Vector3 force = Quaternion.Euler (0, Random.Range(20f, 45f), 0) * Vector3.forward;
		force = force * InputForceScale; 
		rigidBody.AddForce(force);

		audioSource = GetComponent<AudioSource> ();
	}

	void OnCollisionEnter(Collision collision){
		GameObject gameObject = collision.gameObject;

		if (gameObject.CompareTag ("Walls")) {
			audioSource.PlayOneShot (WallSound);
		} else if (gameObject.CompareTag ("Paddle")) {
			audioSource.PlayOneShot (PaddleSound);
		}
	}
}