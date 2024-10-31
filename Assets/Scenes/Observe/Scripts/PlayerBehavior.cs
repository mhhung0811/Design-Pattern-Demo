using UnityEngine;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.Serialization;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] private PlayerHealthSubject healthSubject;
    
    private List<IObserver> observers = new List<IObserver>();
    
    private float maxHealth = 100f; 
    private float health;
    private void Start()
    {
        health = maxHealth;
        
        foreach (IObserver observer in observers)
        {
            healthSubject.Attach(observer);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            health -= 20;
        }

        if (other.CompareTag("Potion"))
        {
            health += 50;
            Destroy(other.gameObject);
        }
        Debug.Log(health);
        healthSubject.Notify(health);
    }
}