using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    public GameObject prefab;
    public FlyweightType type;
    public float despawnDelay = 5f;
    public float speed = 10f;
    
    // Memory-intensive intrinsic data for demonstration
    [System.Serializable]
    public struct BulletIntrinsicData
    {
        public Vector3 direction; // Represents the movement direction
        public float damageMultiplier; // Damage multiplier for this bullet type
        public Color bulletColor; // Color attribute for visual uniqueness
        public int[] trajectoryPoints; // Large array to simulate complex path data

        public BulletIntrinsicData(Vector3 direction, float damageMultiplier, Color bulletColor, int arraySize)
        {
            this.direction = direction;
            this.damageMultiplier = damageMultiplier;
            this.bulletColor = bulletColor;
            trajectoryPoints = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                trajectoryPoints[i] = i; // Populating with sample data
            }
        }
    }
    
    public BulletIntrinsicData[] intrinsicDataArray;

    private void Start()
    {
        // Initialize large intrinsic data array to simulate memory usage
        intrinsicDataArray = new BulletIntrinsicData[1000]; // Adjust size as needed

        for (int i = 0; i < intrinsicDataArray.Length; i++)
        {
            Vector3 randomDirection = new Vector3(Random.value, Random.value, Random.value);
            float randomDamage = Random.Range(0.5f, 2.0f);
            Color randomColor = new Color(Random.value, Random.value, Random.value, 1.0f);
            intrinsicDataArray[i] = new BulletIntrinsicData(randomDirection, randomDamage, randomColor, 1000); // Array size here affects memory
        }
    }
    
    private void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}