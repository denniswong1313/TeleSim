using UnityEngine;
using System.Collections;

public class CollisionDetect : MonoBehaviour {


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
        }
    }
}
