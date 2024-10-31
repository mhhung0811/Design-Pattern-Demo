using UnityEngine;

public class BlueTable : MonoBehaviour, ITable
{
    public void Tabling()
    {
        Debug.Log("Blue Table");
    }
    
    private void OnMouseDown()
    {
        Tabling();
    }
}