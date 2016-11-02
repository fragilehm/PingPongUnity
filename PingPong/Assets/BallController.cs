using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

    public float InputForceScale = 10.0f;
    private Rigidbody rigidBody;

    // Use this for initialization
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();

    }

    //Called for every Physics Engine Update step
    void FixedUpdate()
    {
        float horizontalAxis = Input.GetAxis("Horizontal");
        float verticalAxis = Input.GetAxis("Vertical");

        Vector3 force = new Vector3(horizontalAxis, 0.0f, verticalAxis);
        force *= InputForceScale;

        rigidBody.AddForce(force);
    }

}
