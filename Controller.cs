using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Controller : MonoBehaviour
{
    public float moveSpeed = 6.0f;
    public float turnSpeed = 90;
    private Vector3 accelerate = Vector3.zero;

    private int countLeft;
    private int countRight;
    public Text countTextLeft;
    public Text countTextRight;

    void Start()
    {
        countLeft = 0;
        countRight = 0;
        SetCountText();
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

    void OnTriggerEnter(Collider other)
    {
        CharacterController controller = GetComponent<CharacterController>();

        if (other.gameObject.CompareTag("pathLeft") || other.gameObject.CompareTag("pathRight"))
        {
            other.gameObject.SetActive(false);
            if (other.gameObject.CompareTag("pathLeft"))
            {
                countLeft = countLeft + 1;
                SetCountText();
            }

            if (other.gameObject.CompareTag("pathRight"))
            {
                countRight = countRight + 1;
                SetCountText();
            }

        }

        if ((other.gameObject.CompareTag("Parking")) && (controller.velocity == Vector3.zero))
        {
            gameObject.tag = "finished";
        }
    }

    void SetCountText()
    {
        countTextLeft.text = "Left Hits: " + countLeft.ToString();
        countTextRight.text = "Right Hits: " + countRight.ToString();
    }
}