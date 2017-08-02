using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCapsula : MonoBehaviour
{

    public float movementSpeed = 5f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(Vector3.forward * Time.deltaTime* movementSpeed);
        }
        if (Input.GetKey(KeyCode.S)){
            transform.Translate(Vector3.forward * Time.deltaTime * -movementSpeed);
        }
        if (Input.GetKey(KeyCode.A)){
            transform.Rotate(new Vector3(0f, Input.GetAxis("Horizontal"), 0f));
        }
        if (Input.GetKey(KeyCode.D)){
            transform.Rotate(new Vector3(0f, Input.GetAxis("Horizontal"), 0f));
        }
    }
}
