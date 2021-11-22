using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scales : MonoBehaviour
{
    Weight butterWeight;

    public float totalButter;

    public bool butterReady;

    FPSMovement movement;

    // Start is called before the first frame update
    void Start()
    {
        butterWeight = FindObjectOfType<Weight>();
        movement = FindObjectOfType<FPSMovement>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player") && movement.SpoontButterActive && movement.pickUpRef.action.triggered)
        {

        }
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag == "Butter")
    //    {
    //        totalButter += butterWeight.weight;
    //        Destroy(butterWeight);
    //        if (totalButter == 80)
    //        {
    //            butterReady = true;
    //        }
    //    }
    //}
}
