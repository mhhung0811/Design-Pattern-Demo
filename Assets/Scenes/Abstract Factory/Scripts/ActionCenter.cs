using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class ActionCenter : MonoBehaviour
{
    private RedFurnitureFactory redFactory;
    private BlueFurnitureFactory blueFactory;
    [SerializeField] private TextMeshProUGUI textMeshProUGUI;
    [SerializeField] private BoxCollider2D bound;
    
    private IFurnitureFactory currentFactory;
    private List<GameObject> furnitures = new List<GameObject>();

    private void Start()
    {
        // Init factory
        redFactory = new RedFurnitureFactory();
        blueFactory = new BlueFurnitureFactory();
        
        currentFactory = redFactory;
        textMeshProUGUI.text = "Red Theme";
    }

    public void ChangeTheme()
    {
        if (currentFactory.GetType() == typeof(RedFurnitureFactory))
        {
            currentFactory = blueFactory;
            textMeshProUGUI.text = "Blue Theme";
        }
        else
        {
            currentFactory = redFactory;
            textMeshProUGUI.text = "Red Theme";
        }
    }

    public void CreateChair()
    {
        GameObject obj = currentFactory.createChair();
        obj.transform.position = new Vector3(Random.Range(bound.bounds.min.x, bound.bounds.max.x), Random.Range(bound.bounds.min.y, bound.bounds.max.y), 0);
        furnitures.Add(obj);
    }

    public void CreateTable()
    {
        GameObject obj = currentFactory.CreateTable();
        obj.transform.position = new Vector3(Random.Range(bound.bounds.min.x, bound.bounds.max.x), Random.Range(bound.bounds.min.y, bound.bounds.max.y), 0);
        furnitures.Add(obj);
    }

    public void CreateSofa()
    {
        GameObject obj = currentFactory.CreateSofa();
        obj.transform.position = new Vector3(Random.Range(bound.bounds.min.x, bound.bounds.max.x), Random.Range(bound.bounds.min.y, bound.bounds.max.y), 0);
        furnitures.Add(obj);
    }

    public void Clear()
    {
        foreach (GameObject furniture in furnitures)
        {
            Destroy(furniture);
        }
        furnitures.Clear();
    }
}