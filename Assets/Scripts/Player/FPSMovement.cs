using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FPSMovement : MonoBehaviour
{
    private Drawer drawer;

    [HideInInspector] public InputActionReference pickUpRef;

    public float moveSpeed;
    private Vector2 curInput;

    private Rigidbody rigidbody;

    private Vector2 mouseDelta;

    public Transform cameraContainer;
    public float minXLook;
    public float maxXLook;
    private float camCurXRot;
    public float lookSensitivity;

    [SerializeField] private GameObject spoonButter;

    [Header("Utensils")]
    [SerializeField] private GameObject spoon;

    [Header("Utensil Bools")]
    public bool spoonInHand;

    

    public bool SpoontButterActive;

    private void OnEnable()
    {
        pickUpRef.action.Enable();
    }

    private void OnDisable()
    {
        pickUpRef.action.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        //hide/lock cursor
        Cursor.lockState = CursorLockMode.Locked;
        rigidbody = GetComponent<Rigidbody>();
        drawer = FindObjectOfType<Drawer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (drawer.nearDrawer && pickUpRef.action.triggered)
        {
            spoon.SetActive(true);
            spoonInHand = true;
        }

        if (SpoontButterActive)
            spoonButter.SetActive(true);
    }

    void LateUpdate()
    {
        CameraLook();
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        //move in the direction we are facing
        Vector3 dir = transform.forward * curInput.y + transform.right * curInput.x;
        dir *= moveSpeed;
        dir.y = rigidbody.velocity.y;

        //assign our rigidbody velocity
        rigidbody.velocity = dir;
    }

    //called whenever the players move the mouse
    public void OnLookInput(InputAction.CallbackContext context)
    {
        mouseDelta = context.ReadValue<Vector2>();
    }

    void CameraLook()
    {
        //rotate camera
        //up and down
        camCurXRot += mouseDelta.y * lookSensitivity;
        camCurXRot = Mathf.Clamp(camCurXRot, minXLook, maxXLook);
        cameraContainer.localEulerAngles = new Vector3(-camCurXRot, 0, 0);
        //left and right
        transform.eulerAngles += new Vector3(0, mouseDelta.x * lookSensitivity, 0);
    }

    //WSAD Manager
    public void OnMoveInput(InputAction.CallbackContext context)
    {
        //are we pressing a button
        if(context.phase == InputActionPhase.Performed)
        {
            curInput = context.ReadValue<Vector2>();
        }
        //are no longer pressing a button
        else if(context.phase == InputActionPhase.Canceled)
        {
            curInput = Vector2.zero;
        }
    }
}
