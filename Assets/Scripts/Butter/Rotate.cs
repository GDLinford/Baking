using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 100f;
    [SerializeField] float firePower = 30f;
    bool dragging = false;
    private Rigidbody rigidbody;

    [SerializeField] private GameObject butter;
    [SerializeField] private Transform shotPoint;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void OnMouseDrag()
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
            float x = Input.GetAxis("Mouse X") * rotationSpeed * Time.fixedDeltaTime;

            rigidbody.AddTorque(Vector3.down * x);
        }
        
    }

    void OnMouseDown()
    {
        GameObject firedButter = Instantiate(butter, shotPoint.position, shotPoint.rotation);
        firedButter.GetComponent<Rigidbody>().velocity = shotPoint.transform.right * firePower;
    }
}
