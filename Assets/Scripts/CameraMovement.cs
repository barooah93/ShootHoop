using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

    public float cameraSpeed = 2.0f;

    Camera cameraObject;
    
	// Use this for initialization
	void Start () {
        cameraObject = GetComponentInChildren<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        var xMovement = Input.GetAxis("Mouse X") * cameraSpeed;
        var yMovement = Input.GetAxis("Mouse Y") * cameraSpeed;

        cameraObject.transform.localRotation = Quaternion.Euler(-yMovement, 0, 0) * cameraObject.transform.localRotation;
        transform.rotation = Quaternion.Euler(0,xMovement, 0) * transform.rotation;

    }
}
