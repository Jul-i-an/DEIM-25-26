using UnityEngine;

public class IncreasingOrder : MonoBehaviour
{

    [SerializeField]
    private int _numberOne,     // Variable privada que recibe el primer número
                _numberTwo,     // Variable privada que recibe el segundo número
                _numberThree;   // Variable privada que recibe el tercer número

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        GetIsIncrementalOrder();

    }

    private void GetIsIncrementalOrder()
    {
        
        // Verificamos si el número está en orden creciente
        if ((_numberOne < _numberTwo) && (_numberTwo < _numberThree))
        {

            Debug.Log("Los valores están en orden incremental.");

        }
        else
        {

            Debug.Log("Los valores no están en orden incremental.");

        }

    }

}
