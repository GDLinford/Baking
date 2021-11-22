using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recipe : MonoBehaviour
{
    Scales butterWeight;
    SugarWeighing sugarWeight;

    [SerializeField] private GameObject weighedButter;
    [SerializeField] private GameObject WeighedSugar;

    // Start is called before the first frame update
    void Start()
    {
        butterWeight = FindObjectOfType<Scales>();
        sugarWeight = FindObjectOfType<SugarWeighing>();
    }

    // Update is called once per frame
    void Update()
    {
        if (butterWeight.butterReady)
        {
            weighedButter.SetActive(true);
        }

        if (sugarWeight.SuagrReady)
            WeighedSugar.SetActive(true);
    }
}
