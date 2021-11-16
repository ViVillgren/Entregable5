using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 initialPos = Vector3.zero;
    public float speed = 10.0f;
    private float verticalInput;
    private float turnSpeed = 20.0f;
    private float zMax = 450;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = initialPos;
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Rotate(Vector3.right, turnSpeed * verticalInput * Time.deltaTime);

        if (transform.position.z > zMax)
        {
            Debug.Log($"THE END");
            Time.timeScale = 0;
        }
    }
}
