using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SugarWeighing : MonoBehaviour
{

    Weight sugarWeight;

    public float totalSugar;

    public bool SuagrReady;

    [SerializeField] private Camera MainCam;
    [SerializeField] private Camera SugarCam;

    // Start is called before the first frame update
    void Start()
    {
        sugarWeight = FindObjectOfType<Weight>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SuagrReady)
        {
            MainCam.gameObject.SetActive(true);
            SugarCam.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Sugar")
        {
            totalSugar += sugarWeight.weight;
            Destroy(sugarWeight);
            if (totalSugar == 100)
            {
                SuagrReady = true;
            }
        }
    }
}
