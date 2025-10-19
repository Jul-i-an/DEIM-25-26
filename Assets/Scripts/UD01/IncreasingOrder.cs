using UnityEngine;

public class IncreasingOrder : MonoBehaviour
{

    [SerializeField]
    private int _numberOne,     // Variable privada que recibe el primer n�mero
                _numberTwo,     // Variable privada que recibe el segundo n�mero
                _numberThree;   // Variable privada que recibe el tercer n�mero

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        GetIsIncrementalOrder();

    }

    private void GetIsIncrementalOrder()
    {
        
        // Verificamos si el n�mero est� en orden creciente
        if ((_numberOne < _numberTwo) && (_numberTwo < _numberThree))
        {

            Debug.Log("Los valores est�n en orden incremental.");

        }
        else
        {

            Debug.Log("Los valores no est�n en orden incremental.");

        }

    }

}
