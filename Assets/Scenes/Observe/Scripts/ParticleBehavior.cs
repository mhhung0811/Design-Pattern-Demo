using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleBehavior : MonoBehaviour, IObserver
{
    [SerializeField] private PlayerHealthSubject playerHealthSubject;
    [SerializeField] private ParticleSystem particle;
    [SerializeField] private GameObject player;
    
    private ParticleSystem particleInstance;
    
    void SpawParticle()
    {
        particleInstance = Instantiate(particle, player.transform.position, Quaternion.identity);
    }

    public void OnNotify(float value)
    {
        SpawParticle();
    }
    
    private void OnEnable()
    {
        playerHealthSubject.Attach(this);
    }

    private void OnDisable()
    {
        playerHealthSubject.Dettach(this);
    }
}
