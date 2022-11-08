using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody rig;

    public Camera normalCam;

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

    private void FixedUpdate()
    {
        float t_hmove = Input.GetAxisRaw("Horizontal");
        float t_vmove = Input.GetAxisRaw("Vertical");

        Vector3 t_direction = new Vector3(t_hmove, 0f, t_vmove);
        t_direction.Normalize();

        rig.velocity = transform.TransformDirection(t_direction) * speed * Time.deltaTime;

        //if (t_hmove == 0 && t_vmove == 0)
        //{
        //    HeadBob(idleCounter, 0.003f, 0.03f);
        //    idleCounter += Time.deltaTime * 2f;
        //    normalCam.transform.localPosition = Vector3.Lerp(normalCam.transform.localPosition, targetPosition, Time.deltaTime * 2f);
        //}
        //else
        //{
        //    HeadBob(movementCounter, 0.02f, 0.02f);
        //    movementCounter += Time.deltaTime * 2f;
        //    normalCam.transform.localPosition = Vector3.Lerp(normalCam.transform.localPosition, targetPosition, Time.deltaTime * 6f);
        //}
    }

    //void HeadBob(float p_z, float p_x_intensity, float p_y_intensity)
    //{
    //    normalCam.transform.localPosition = camOrigin + new Vector3(Mathf.Cos(p_z) * p_x_intensity, Mathf.Sin(p_z * 2) * p_y_intensity, 0f);

    //}
}