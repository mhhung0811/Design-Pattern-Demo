using UnityEngine;

namespace Scenes.Observe.Scripts
{
    public class Potions : MonoBehaviour, IObserver
    {
        public GameObject potionPrefab;
        
        public PlayerHealthSubject playerHealthSubject;
    
        private void OnEnable()
        {
            playerHealthSubject.Attach(this);
        }
        
        private void OnDisable()
        {
            playerHealthSubject.Dettach(this);
        }
        
        public void OnNotify(float value)
        {
            if (value <= 50f)
            {
                GameObject obj = Instantiate(potionPrefab, transform.position, Quaternion.identity);
                obj.SetActive(true);
            }
        }
    }
}