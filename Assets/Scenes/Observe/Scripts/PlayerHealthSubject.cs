using System.Collections.Generic;using UnityEngine;

// [CreateAssetMenu(fileName = "PlayerHealthEvent", menuName = "Event/PlayerHealthEvent")]
public class PlayerHealthSubject : MonoBehaviour, ISubject
{
    private List<IObserver> observers = new List<IObserver>();

    public void Attach(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Dettach(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void Notify(float value)
    {
        observers.ForEach(o => o.OnNotify(value));
    }
}