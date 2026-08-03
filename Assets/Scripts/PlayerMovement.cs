using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;

public class PlayerMovement : MonoBehaviour
{
    private Controller controls;
    private Vector3 velocity;
    private Vector2 move;
    private CharacterController controller;
    private bool isGrounded;
    private float moveSpeed = 120f;
    public float gravity = -9.81f;
    public float JumpHeight = 10.4f;
    public Transform ground;
    public LayerMask groundMask;
    public float distanceToGround = 0.4f;
    public float sprintSpeed;
    public float walkSpeed;
    public KeyCode sprintKey = KeyCode.LeftShift;

    public MovementState state;

    public enum MovementState
    {
        move,
        sprinting,
    }

    private void Awake()
    {
        controls = new Controller();
        controller = GetComponent<CharacterController>();
    }
    
    private void StateHandler()
    {
        if(isGrounded && Input.GetKey(sprintKey))
        {
            state = MovementState.sprinting;
            moveSpeed = sprintSpeed;
        }

        else if(isGrounded)
        {
            state = MovementState.move;
            moveSpeed = walkSpeed;
        }
    }
    
    void Update()
    {
        Gravity();
        Movement();
        JumpH();

        StateHandler();
    }

    private void Gravity() 
    {
        isGrounded = Physics.CheckSphere(ground.position, distanceToGround, groundMask);
        
        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    private void Movement() 
    {
        move = controls.Player.Move.ReadValue<Vector2>();
        Vector3 distance = (move.y * transform.forward) + (move.x * transform.right);
        controller.Move(distance * moveSpeed * Time.deltaTime);
    }

    private void JumpH()
    {
        if(controls.Player.Jump.triggered)
        {
            velocity.y = Mathf.Sqrt(JumpHeight * -2f * gravity);
        }
    }

    private void OnEnable() 
    {
        controls.Enable();
    }

    private void OnDisable() 
    {
        controls.Disable();
    }


}
