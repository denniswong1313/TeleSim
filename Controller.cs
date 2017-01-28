using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour
{

    public float moveSpeed = 6.0f;
    public float turnSpeed = 90;
    private Vector3 accelerate = Vector3.zero;

    private float count;

    void Start()
    {
        count = 0;
    }

    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();

        accelerate = new Vector3(0, 0, Input.GetAxis("Vertical"));
        accelerate = transform.TransformDirection(accelerate);
        accelerate *= moveSpeed;

        float turn = Input.GetAxis("Horizontal") * turnSpeed;

        controller.Move(accelerate * Time.deltaTime);
        transform.Rotate(0, turn * Time.deltaTime, 0);
    }

    void onTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Path"))
        {
            other.gameObject.SetActive(false);
        }
    }
}