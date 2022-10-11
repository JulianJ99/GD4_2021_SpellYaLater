using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraMove : MonoBehaviour
{
    private const float moveSpeed = 7.5f;
    private const float cameraSpeed = 3.0f;

    public Quaternion TargetRotation { private set; get; }
    



    private void Awake()
    {

        Cursor.lockState = CursorLockMode.Locked;

        TargetRotation = transform.rotation;
    }


    public void ResetTargetRotation()
    {
        TargetRotation = Quaternion.LookRotation(transform.forward, Vector3.up);
    }
}
