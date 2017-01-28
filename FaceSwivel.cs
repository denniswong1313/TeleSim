using UnityEngine;
using System.Collections;

public class FaceSwivel : MonoBehaviour {

    public float swivelSpeed = 90;

    // Update is called once per frame
    void Update () {

        if (Input.GetKey("l"))
        {
            transform.Rotate(0, swivelSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey("j"))
        {
            transform.Rotate(0, -swivelSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey("k"))
        {
            transform.Rotate(swivelSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("i"))
        {
            transform.Rotate(-swivelSpeed * Time.deltaTime, 0, 0);
        }

    }
}
