using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float gravity = 9.8f;
    public float jumpForce;
    public float speed;
    private Vector3 _MoveVector; 
    private CharacterController _characterController;



    private float _fallVelocity = 0;
    // Start is called before the first frame update
    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        //movement
        _MoveVector = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            _MoveVector += transform.forward;
        }
        if(Input.GetKey(KeyCode.S))
        {
            _MoveVector -= transform.forward;
        }
        if (Input.GetKey(KeyCode.D))
        {
            _MoveVector += transform.right;
        }
        if (Input.GetKey(KeyCode.A))
        {
            _MoveVector -= transform.right;
        }
        //jump
        if (Input.GetKeyDown(KeyCode.Space) && _characterController.isGrounded)
        {
            _fallVelocity = -jumpForce;
        }
    }



    // Update is called once per frame
    void FixedUpdate()
    {
        _characterController.Move(_MoveVector * speed * Time.fixedDeltaTime);

        _fallVelocity += gravity * Time.fixedDeltaTime;
        _characterController.Move(Vector3.down * _fallVelocity * Time.fixedDeltaTime);
    }
}
