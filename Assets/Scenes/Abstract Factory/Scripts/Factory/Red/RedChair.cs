
using UnityEngine;

public class RedChair : MonoBehaviour, IChair
{
    public void Chairing()
    {
        Debug.Log("Red Chair");
    }
    
    private void OnMouseDown()
    {
        Chairing();
    }
}