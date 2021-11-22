using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spoon : MonoBehaviour
{
    //private butter butter;
    private FPSMovement movement;

    [SerializeField] private GameObject Spoonbutter;

    // Start is called before the first frame update
    void Start()
    {
        movement = FindObjectOfType<FPSMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (movement.SpoontButterActive == true)
        {
            Spoonbutter.SetActive(true);
        }
    }
}
