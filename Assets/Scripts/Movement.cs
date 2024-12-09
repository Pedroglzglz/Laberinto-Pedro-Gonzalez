using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 5f;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = transform.right * horizontalInput + transform.forward * verticalInput;

        controller.Move(movementDirection * speed * Time.deltaTime);
    }
}
