using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderController : MonoBehaviour
{
    public float m_Speed = 12f;
    public float m_TurnSpeed = 180f;
    private Rigidbody m_Rigidbody;              // Reference used to move the spider.
    private int groundLayer;                      // A layer mask so that a ray can be cast just at gameobjects on the ground layer.
    public string m_MovementAxisName;             // The name of the input axis for moving forward and back.
    public string m_TurnAxisName;                 // The name of the input axis for turning.
    private float m_MovementInputValue;         // The current value of the movement input.
    private float m_TurnInputValue;             // The current value of the turn input.

    private void Awake()
    {
        // Create a layer mask for the floor layer.
        groundLayer = LayerMask.GetMask("Ground");

        m_Rigidbody = GetComponent<Rigidbody>();

        Transform[] children =  GetComponentsInChildren<Transform>();
    }

      private void Start()
    {        
        m_MovementAxisName = "Vertical";
        m_TurnAxisName = "Horizontal";
    }


    // Update is called once per frame
    void Update()
    {
        // Store the value of both input axes.
        m_MovementInputValue = Input.GetAxis(m_MovementAxisName);
        m_TurnInputValue = Input.GetAxis(m_TurnAxisName);
    }

    private void FixedUpdate()
    {
        // Adjust the rigidbodies position and orientation in FixedUpdate.
        Move();
        Turn();
    }

        private void OnEnable()
    {
        // When the tank is turned on, make sure it's not kinematic.
        m_Rigidbody.isKinematic = false;

        // Also reset the input values.
        m_MovementInputValue = 0f;
        m_TurnInputValue = 0f;
    }

    private void Move()
    {
        // Create a vector in the direction the tank is facing with a magnitude based on the input, speed and the time between frames.
        Vector3 movement = transform.forward * m_MovementInputValue * m_Speed * Time.deltaTime;

        // Apply this movement to the rigidbody's position.
        m_Rigidbody.MovePosition(m_Rigidbody.position + movement);
    }

       private void Turn()
    {
        // Determine the number of degrees to be turned based on the input, speed and time between frames.
        float turn = m_TurnInputValue * m_TurnSpeed * Time.deltaTime;

        // Make this into a rotation in the y axis.
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);

        // Apply this rotation to the rigidbody's rotation.
        m_Rigidbody.MoveRotation(m_Rigidbody.rotation * turnRotation);
    }

}
