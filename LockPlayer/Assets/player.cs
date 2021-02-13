using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    
    [SerializeField] private Transform selfTransform;    
    [SerializeField] private Transform cameraTransform;
    [SerializeField] private float movementSpeed = 0.1f;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float cameraSensibility = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        RotateCamera();
    }

    private void MovePlayer()
    {

        Vector3 cameraRight = cameraTransform.right;
        Vector3 cameraforward = cameraTransform.forward;
        Vector3 deltaposition = new Vector3(cameraRight.x, 0f, cameraRight.z) * Input.GetAxis("Horizontal") +
                                new Vector3(cameraforward.x, 0f, cameraforward.z) * Input.GetAxis("Vertical");

        selfTransform.position += deltaposition * movementSpeed;

        rb.MovePosition(rb.position + deltaposition * movementSpeed);
    }
    
    public void  RotateCamera()
    {
        float pitch = Input.GetAxis("Mouse Y");
        pitch = Mathf.Clamp(pitch, -90f, 90f);
        
        
        cameraTransform.eulerAngles += new Vector3(pitch, Input.GetAxis("Mouse X"), 0f) *cameraSensibility;    
    }
}
