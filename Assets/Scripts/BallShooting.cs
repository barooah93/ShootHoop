using UnityEngine;
using System.Collections;

public class BallShooting : MonoBehaviour {

    public GameObject basketball;
    public float launchSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject ball = GameObject.Instantiate(basketball, transform.position, transform.rotation) as GameObject;
            Rigidbody ballRB = ball.GetComponent<Rigidbody>();
            Camera cam = GetComponent<Camera>();
            ballRB.velocity = cam.transform.rotation * Vector3.forward * launchSpeed;
        }
	}
}
