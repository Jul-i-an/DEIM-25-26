using UnityEngine;

public class Number : MonoBehaviour
{
    //Zona de Variables Globales

    [SerializeField]
    private int _numberOne;     // Variable privada que recibe el n�mero

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // Llamamos al m�todo de substraci�n
        GetAddition();

    }

    // Update is called once per frame
    private void GetAddition()
    {

        // Variable local que contiene el valor calculado
        int temporalNumber = _numberOne + 1 ;

        // Mostramos el resultado del script por pantalla
        Debug.Log("El n�mero " + _numberOne + " incrementado en uno es: " + temporalNumber);

    }
}
