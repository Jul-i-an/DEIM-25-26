using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    //Zona de Variables globales
    [SerializeField]
    private int _numberOne,     // Variable privada que recibe el primer n�mero
                _numberTwo,     // Variable privada que recibe el segundo n�mero
                _numberThree;   // Variable privada que recibe el tercer n�mero


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

        while (!ordered)    // Consideramos que no est� ordenado la secuencia
        {

            if (_numberOne > _numberTwo)
            {
                // El primer n�mero no puede ser mayor que el segundo.
                // Si es as� hay que intercambiar los valores
                numberTemp = _numberTwo;
                _numberTwo = _numberOne;
                _numberOne = numberTemp;

            }
            else if (_numberTwo > _numberThree)
            {
                // El segundo n�mero no puede ser mayor que el tercero.
                // Si es as� hay que intercambiar los valores

                numberTemp = _numberThree;
                _numberThree = _numberTwo;
                _numberTwo = numberTemp;

            }
            else if (_numberOne > _numberThree)
            {
                // El primer n�mero no puede ser mayor que el tercero.
                // Si es as� hay que intercambiar los valores

                numberTemp = _numberThree;
                _numberThree = _numberOne;
                _numberOne = numberTemp;

            }
            else 
            {

                // Se cumple que los 3 n�meros ya est�n en orden
                ordered = true;

            }

        }

        // Ya hemos salido del bucle, mostramos los n�meros ordenados
        Debug.Log("La secuencia ordenada es: " + _numberOne + ", " + _numberTwo + ", " + _numberThree + ".");

    }

}
