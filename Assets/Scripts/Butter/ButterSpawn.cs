using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButterSpawn : MonoBehaviour
{
    public Transform butter;
    public Transform SpawnPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Instantiate(butter, new Vector3(27, 7, -32.5f), butter.rotation);
    }
}
