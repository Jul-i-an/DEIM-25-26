using UnityEngine;

public class Change : MonoBehaviour
{

    //Zona de Variables Globales

    [SerializeField]
    private int[] _valueArray = new int[5];     // Variable privada que recibe el número

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // Primero inicializamos el array a 1 y mostramos el valor por pantalla
        for (int i = 0; i < _valueArray.Length; i++)
        {
            _valueArray[i] = 1;
            Debug.Log("El valor de la posición " + i + " del array es: " + _valueArray[i]);

        }

        // Procedo a cambiar dos valores del array
        _valueArray[0] = 42;
        _valueArray[4] = 42;

        // Mostramos el valor final de cada elemento del array por pantalla
        for (int i = 0; i < _valueArray.Length; i++)
        {
            Debug.Log("El valor de la posición " + i + " del array es: " + _valueArray[i]);

        }

    }


}
