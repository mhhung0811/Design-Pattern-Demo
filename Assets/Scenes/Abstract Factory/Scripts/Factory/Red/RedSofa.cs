
using UnityEngine;

public class RedSofa : MonoBehaviour, ISofa
{
    public void Sofing()
    {
        Debug.Log("Red Sofa");
    }
    
    private void OnMouseDown()
    {
        Sofing();
    }
}