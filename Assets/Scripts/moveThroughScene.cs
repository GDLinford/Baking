using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveThroughScene : MonoBehaviour
{
    [SerializeField] private Camera AreaToStart;
    [SerializeField] private GameObject buttonPressed;
    [SerializeField] private Camera MainCam;

    bool sugarActive = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        AreaToStart.gameObject.SetActive(true);
        buttonPressed.SetActive(false);
        MainCam.gameObject.SetActive(false);
    }
}
