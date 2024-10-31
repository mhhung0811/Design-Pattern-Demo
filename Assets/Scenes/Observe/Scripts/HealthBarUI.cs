using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarUI : MonoBehaviour, IObserver
{
    public Slider slider;
    public PlayerHealthSubject playerHealthSubject;
    
    void Start()
    {
        slider.value = 1;
    }
    
    public void OnNotify(float value)
    {
        slider.value = value / 100;
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