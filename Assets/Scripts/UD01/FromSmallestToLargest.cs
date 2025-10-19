using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    //Zona de Variables globales
    [SerializeField]
    private int _numberOne,     // Variable privada que recibe el primer número
                _numberTwo,     // Variable privada que recibe el segundo número
                _numberThree;   // Variable privada que recibe el tercer número


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        GetOrderedNumbers();

    }

    private void GetOrderedNumbers() 
    {

        // Variable temporal para contener el valor de salida del bucle
        int numberTemp;
        bool ordered = false;

        while (!ordered)    // Consideramos que no está ordenado la secuencia
        {

            if (_numberOne > _numberTwo)
            {
                // El primer número no puede ser mayor que el segundo.
                // Si es así hay que intercambiar los valores
                numberTemp = _numberTwo;
                _numberTwo = _numberOne;
                _numberOne = numberTemp;

            }
            else if (_numberTwo > _numberThree)
            {
                // El segundo número no puede ser mayor que el tercero.
                // Si es así hay que intercambiar los valores

                numberTemp = _numberThree;
                _numberThree = _numberTwo;
                _numberTwo = numberTemp;

            }
            else if (_numberOne > _numberThree)
            {
                // El primer número no puede ser mayor que el tercero.
                // Si es así hay que intercambiar los valores

                numberTemp = _numberThree;
                _numberThree = _numberOne;
                _numberOne = numberTemp;

            }
            else 
            {

                // Se cumple que los 3 números ya están en orden
                ordered = true;

            }

        }

        // Ya hemos salido del bucle, mostramos los números ordenados
        Debug.Log("La secuencia ordenada es: " + _numberOne + ", " + _numberTwo + ", " + _numberThree + ".");

    }

}
