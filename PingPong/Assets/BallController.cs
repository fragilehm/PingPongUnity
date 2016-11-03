using UnityEngine;

public class BallController : MonoBehaviour
{

    public float InputForceScale =
            10.0f;
    public float InitialAngle =
            20.0f;

    private Rigidbody rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();

        Vector3 force = Quaternion.Euler(0, Random.Range(20f, 45f), 0) * Vector3.forward;
        force = force * InputForceScale;
        rigidBody.AddForce(force);

        
    }

}