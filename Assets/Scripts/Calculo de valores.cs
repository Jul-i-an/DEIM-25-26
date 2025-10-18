using Mono.Cecil.Cil;
using UnityEngine;

public class Calculodevalores : MonoBehaviour
{

    // Variables Globales
    private float _euro;
    public float Dollar;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        _euro = 0.90f;

        Debug.Log("El valor de conversión de $ a € es: " + GetDollarToEuro());

    }

    private float GetDollarToEuro() {

        // Variables locales
        float conversion = 0.0f;

        // Calcular la conversión de dólares a euros

        conversion = Dollar * _euro;

        // Devolver el valor de tipo "float"
        return conversion;

    }

}
