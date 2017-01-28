using UnityEngine;
using System.Collections;

public class CameraFOV : MonoBehaviour {

    public float fov = 100;

	// Use this for initialization
	void Start () {
        Camera.main.fieldOfView = fov;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
