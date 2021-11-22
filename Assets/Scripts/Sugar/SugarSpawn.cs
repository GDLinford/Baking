using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SugarSpawn : MonoBehaviour
{
    shaker shakerdrag;
    [SerializeField] private float SpawnTime = 0.5f;
    private float lastSpawnTime;
    private SugarPool sPool;

    SugarWeighing sugarWeight;

    // Start is called before the first frame update
    void Start()
    {
        sPool = FindObjectOfType<SugarPool>();
        shakerdrag = FindObjectOfType<shaker>();
        sugarWeight = FindObjectOfType<SugarWeighing>();
    }

    // Update is called once per frame
    void Update()
    {
        if (shakerdrag.dragging)
        {
            lastSpawnTime += Time.deltaTime;
            if (lastSpawnTime >= SpawnTime)
            {
                GameObject newSugar = sPool.GetSugar();
                newSugar.transform.position = this.transform.position;
                lastSpawnTime = 0f;
            }

            
        }

        else if (sugarWeight.SuagrReady)
        {
            sPool.ReturnSugar(this.gameObject);
        }

    }
}
