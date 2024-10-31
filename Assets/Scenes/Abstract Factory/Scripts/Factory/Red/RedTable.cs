
using UnityEngine;

public class RedTable : MonoBehaviour, ITable
{
    public void Tabling()
    {
        Debug.Log("Red Table");
    }
    
    private void OnMouseDown()
    {
        Tabling();
    }
}