using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;


public class Nube : MonoBehaviour
{


    public GameObject [] frutas;
    public static int contador = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current == null) return;

        if (Keyboard.current.rightArrowKey.isPressed)
        {
            gameObject.transform.position = 
                new Vector3(gameObject.transform.position.x + .05f, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        else if (Keyboard.current.leftArrowKey.isPressed)
        {
            gameObject.transform.position = 
                new Vector3(gameObject.transform.position.x - .05f, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        else if (Keyboard.current.upArrowKey.wasPressedThisFrame)
        {   
            int numero = Random.Range(0, frutas.Length);
            GameObject nuevo = Instantiate(frutas[numero],
            new Vector3(gameObject.transform.position.x, 
            gameObject.transform.position.y, 
            gameObject.transform.position.z), 
            gameObject.transform.rotation);
            nuevo.name = contador + "";
            contador++;
            
        }
    }
}