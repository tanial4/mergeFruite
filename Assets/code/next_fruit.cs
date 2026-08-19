using UnityEngine;

public class MostrarProximaFruta : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public float escalaMaxima = 0.5f; 

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void MostrarFruta(GameObject prefabFruta)
    {
        SpriteRenderer prefabSprite = prefabFruta.GetComponent<SpriteRenderer>();
        
        if (prefabSprite != null && spriteRenderer != null)
        {
            spriteRenderer.sprite = prefabSprite.sprite;
            
            transform.localScale = new Vector3(escalaMaxima, escalaMaxima, 1f);
            
            Debug.Log("Sprite actualizado: " + prefabSprite.sprite.name);
        }
    }
}