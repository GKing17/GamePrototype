using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed;
    public float rotX;
    public float rotY;
    public float rotZ;
    
    Rigidbody m_Rigidbody;
    Vector3 m_Movement;
   // Animator m_Animator;
   // Quaternion m_Rotation = Quaternion.identity;
    
    // Start is called before the first frame update
    void Start()
    {
      //  m_Animator = GetComponent<Animator>();
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    { 
        float horizontal = Input.GetAxis("Horizontal");
       float vertical = Input.GetAxis("Vertical");

       Vector3 move = new Vector3(horizontal,0.0f,vertical);
       Vector3 position = m_Rigidbody.position;
       position = position + move * (speed * Time.deltaTime);
       m_Rigidbody.MovePosition(position);

       //  bool hasHorizontalInput = !Mathf.Approximately (horizontal, 0f);
       // bool hasVerticalInput = !Mathf.Approximately (vertical, 0f);
       // bool isWalking = hasHorizontalInput || hasVerticalInput;
       // m_Animator.SetBool ("IsWalking", isWalking);

       // Vector3 desiredForward = Vector3.RotateTowards (transform.forward, m_Movement, turnSpeed * Time.deltaTime, 0f);
       // m_Rotation = Quaternion.LookRotation (desiredForward);
    }
    
}
