using UnityEngine;

public class merge : MonoBehaviour
{
    public GameObject nuevaFruta;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == gameObject.tag)
        {
            // Si es la fruta máxima (melon), destruir sin crear nueva
            if (gameObject.tag == "melon")
            {
                Destroy(collision.gameObject);
                Destroy(gameObject);
                return;
            }

            int num1 = int.Parse(collision.gameObject.name);
            int num2 = int.Parse(gameObject.name);
            
            if (num1 < num2)
            {
                GameObject nuevo = Instantiate(nuevaFruta,
                    new Vector3(gameObject.transform.position.x, 
                        gameObject.transform.position.y, 
                        gameObject.transform.position.z), 
                    gameObject.transform.rotation);
                
                nuevo.name = Nube.contador + "";
                Nube.contador++;
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }
        }
    }
}