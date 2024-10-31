using UnityEngine;

public class BlueSofa : MonoBehaviour, ISofa
{
    public void Sofing()
    {
        Debug.Log("Blue Sofa");
    }
    
    private void OnMouseDown()
    {
        Sofing();
    }
}