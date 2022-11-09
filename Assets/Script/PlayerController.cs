using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody rig;
    public float jumpForce;
    public Camera normalCam;
    public Transform groundDetector;
    public LayerMask ground;
    //private Vector3 camOrigin;

    //private Vector3 targetPosition;
    //private float movementCounter;
    //private float idleCounter;


    private void Start()
    {
        Camera.main.enabled = false;
        rig = GetComponent<Rigidbody>();
        //camOrigin = normalCam.transform.localPosition;
    }

    private void Update()
    {
        float t_hmove = Input.GetAxisRaw("Horizontal");
        float t_vmove = Input.GetAxisRaw("Vertical");

        bool jump = Input.GetKeyDown(KeyCode.Space);

        bool isGrounded = Physics.Raycast(groundDetector.position, Vector3.down, 0.1f, ground);
        bool isJumping = jump && isGrounded;
        
        if (isJumping)
        {
            rig.AddForce(Vector3.up * jumpForce);
        }

        Vector3 t_direction = new Vector3(t_hmove, 0f, t_vmove);
        t_direction.Normalize();

        Vector3 t_targetVelocity = transform.TransformDirection(t_direction) * speed * Time.deltaTime;
        t_targetVelocity.y = rig.velocity.y;
        rig.velocity = t_targetVelocity;
    }
}