using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SugarPool : MonoBehaviour
{
    [SerializeField] private GameObject sugarPrefab;
    [SerializeField] private Queue<GameObject> sugarPool = new Queue<GameObject>();
    [SerializeField] private int poolSize = 500;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < poolSize; i++)
        {
            GameObject sugar = Instantiate(sugarPrefab);
            sugarPool.Enqueue(sugar);
            sugar.SetActive(false);
        }
    }

    public GameObject GetSugar()
    {
        if(sugarPool.Count > 0)
        {
            GameObject sugar = sugarPool.Dequeue();
            sugar.SetActive(true);
            return sugar;
        }
        else
        {
            GameObject sugar = Instantiate(sugarPrefab);
            return sugar;
        }
    }

    public void ReturnSugar(GameObject sugar)
    {
        sugarPool.Enqueue(sugar);
        sugar.SetActive(false);
    }
}
