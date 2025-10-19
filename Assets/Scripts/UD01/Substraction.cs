using UnityEngine;

public class Substraction : MonoBehaviour
{
    //Zona de Variables Globales

    [SerializeField]
    private int _numberOne;     // Variable privada que recibe el número

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // Llamamos al método de substración
        GetSubstration();

    }

    // Update is called once per frame
    private void GetSubstration()
    {

        // Variable local que contiene el valor calculado
        int temporalNumber = 0;

        for (int i = 1; i < _numberOne;  i++)
        {

            temporalNumber -= i;

        }

        // Mostramos el resultado del script por pantalla
        Debug.Log("La resta entre 1 y " + _numberOne + ", es :" + temporalNumber);

    }
}
