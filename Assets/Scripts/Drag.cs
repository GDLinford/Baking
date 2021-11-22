using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    [SerializeField] float dragSpeed = 10f;
    Rigidbody rigidbody;
    public bool dragging = false;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.isKinematic = true;
    }

    private void OnMouseDrag()
    {
        dragging = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            dragging = false;
        }
    }

    void FixedUpdate()
    {
        if (dragging)
        {
            rigidbody.isKinematic = false;

            float x = Input.GetAxis("Mouse X") * dragSpeed * Time.fixedDeltaTime;

            rigidbody.AddForce(Vector3.right * x);
        }

    }
}
