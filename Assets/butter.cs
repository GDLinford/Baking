using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butter : MonoBehaviour
{
    private FPSMovement movement;

    // Start is called before the first frame update
    void Start()
    {
        movement = FindObjectOfType<FPSMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Player") && movement.spoonInHand == true)
        {
            Debug.Log("jhduejwfoejwnif");
            movement.SpoontButterActive = true;
        }
        
    }
}
