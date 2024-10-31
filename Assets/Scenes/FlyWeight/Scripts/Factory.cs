using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Random = UnityEngine.Random;

public class Factory : MonoBehaviour
{
    public List<FlyweightSettings> flyweightSettings;
    public List<GameObject> prefabs;
    public BoxCollider2D bound;
    public int num;
    private int iter;

    private void Start()
    {
        iter = num;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            while (iter > 0)
            {
                var flyweight = flyweightSettings[iter % 2].Create();
                flyweight.transform.position = new Vector3(Random.Range(bound.bounds.min.x, bound.bounds.max.x), Random.Range(bound.bounds.min.y, bound.bounds.max.y), 0);
                flyweight.gameObject.SetActive(true);
                iter--;
            }
            
            iter = num;
        }
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            while (iter > 0)
            {
                var flyweight = Instantiate(prefabs[iter % 2]);
                flyweight.transform.position = new Vector3(Random.Range(bound.bounds.min.x, bound.bounds.max.x), Random.Range(bound.bounds.min.y, bound.bounds.max.y), 0);
                flyweight.gameObject.SetActive(true);
                iter--;
            }

            iter = num;
        }
    }
}