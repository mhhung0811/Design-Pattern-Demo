
using UnityEngine;

// [CreateAssetMenu (fileName = "RedFurnitureFactory", menuName = "Factory/RedFurniture Factory")]
public class RedFurnitureFactory : IFurnitureFactory
{
    public GameObject createChair()
    {
        GameObject chair = new GameObject();
        chair.AddComponent<RedChair>();
        
        // Set default sprite
        SpriteRenderer spriteRenderer = chair.AddComponent<SpriteRenderer>();
        spriteRenderer.color = Color.red;
        Texture2D tex = Resources.Load("Triangle") as Texture2D;
        Sprite sprite = Sprite.Create(tex, new Rect(0.0f,0.0f,tex.width,tex.height), new Vector2(0.5f, 0.5f), (float) tex.width);
        spriteRenderer.sprite = sprite;
        chair.AddComponent<BoxCollider2D>();
        
        return chair;
    }

    public GameObject CreateTable()
    {
        GameObject table = new GameObject();
        table.AddComponent<RedTable>();
        
        // Set default sprite
        SpriteRenderer spriteRenderer = table.AddComponent<SpriteRenderer>();
        spriteRenderer.color = Color.red;
        Texture2D tex = Resources.Load("Square") as Texture2D;
        Sprite sprite = Sprite.Create(tex, new Rect(0.0f,0.0f,tex.width,tex.height), new Vector2(0.5f, 0.5f), (float) tex.width);
        spriteRenderer.sprite = sprite;
        table.AddComponent<BoxCollider2D>();

        return table;
    }

    public GameObject CreateSofa()
    {
        GameObject sofa = new GameObject();
        sofa.AddComponent<RedSofa>();
        
        // Set default sprite
        SpriteRenderer spriteRenderer = sofa.AddComponent<SpriteRenderer>();
        spriteRenderer.color = Color.red;
        Texture2D tex = Resources.Load("Circle") as Texture2D;
        Sprite sprite = Sprite.Create(tex, new Rect(0.0f,0.0f,tex.width,tex.height), new Vector2(0.5f, 0.5f), (float) tex.width);
        spriteRenderer.sprite = sprite;
        sofa.AddComponent<BoxCollider2D>();
        
        return sofa;
    }
}