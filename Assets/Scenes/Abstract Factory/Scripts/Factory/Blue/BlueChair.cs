using System;
using Unity.VisualScripting;
using UnityEngine;

public class BlueChair : MonoBehaviour, IChair
{
    public void Chairing()
    {
        Debug.Log("Blue Chair");
    }
    private void OnMouseDown()
    {
        Chairing();
    }
}