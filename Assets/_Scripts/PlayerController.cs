using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;

    public Rigidbody2D rb;
    public Camera cameraView;

    public float moveSpeed = 5f;
    private Vector2 keyInput;
    private Vector2 mouseInput;

    public float mouseSensitivity = 1f;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
    }

    void Update()
    {
        // Player movement
        keyInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        Vector3 moveHorizontal = -transform.up * keyInput.x;
        Vector3 moveVertical = transform.right * keyInput.y;
        rb.velocity = (moveHorizontal + moveVertical) * moveSpeed;

        // Player mouse view
        mouseInput = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y")) * mouseSensitivity;
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z - mouseInput.x);
        cameraView.transform.localRotation = Quaternion.Euler(cameraView.transform.localRotation.eulerAngles + new Vector3(0f, mouseInput.y, 0f));
    }

}