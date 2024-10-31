using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flyweight : MonoBehaviour
{
    public FlyweightSettings settings;

    private void OnEnable()
    {
        // StartCoroutine(DespawnAfterDelay(settings.despawnDelay));
    }
    
    private void Update()
    {
        transform.Translate(settings.speed * Time.deltaTime, 0, 0);
    }

    IEnumerator DespawnAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(gameObject);
    }
}