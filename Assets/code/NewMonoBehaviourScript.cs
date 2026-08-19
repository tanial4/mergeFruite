using UnityEngine;
using UnityEngine.InputSystem;

public class Nube : MonoBehaviour
{
    public GameObject[] frutas;
    public static int contador = 0;
    
    private int proximaFrutaIndex;
    private MostrarProximaFruta nextFruitDisplay;

    void Start()
    {
        nextFruitDisplay = GameObject.Find("next_fruit").GetComponent<MostrarProximaFruta>();
        proximaFrutaIndex = Random.Range(0, frutas.Length);
        ActualizarProximaFruta();
    }

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
            GameObject nuevo = Instantiate(frutas[proximaFrutaIndex],
                new Vector3(gameObject.transform.position.x, 
                gameObject.transform.position.y, 
                gameObject.transform.position.z), 
                gameObject.transform.rotation);
            
            nuevo.name = contador + "";
            contador++;
            
            proximaFrutaIndex = Random.Range(0, frutas.Length);
            ActualizarProximaFruta();
        }
    }

    void ActualizarProximaFruta()
    {
        nextFruitDisplay.MostrarFruta(frutas[proximaFrutaIndex]);
    }
}