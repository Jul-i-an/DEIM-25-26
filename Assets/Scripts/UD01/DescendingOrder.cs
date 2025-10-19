using UnityEngine;

public class DescendingOrder : MonoBehaviour
{
    [SerializeField]
    private int _numberOne,     // Variable privada que recibe el primer número
                _numberTwo,     // Variable privada que recibe el segundo número
                _numberThree;   // Variable privada que recibe el tercer número

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        GetIsDescendingOrder();

    }

    private void GetIsDescendingOrder()
    {
        
        // Verificamos si los números están en orden decreciente
        if ((_numberOne > _numberTwo) && (_numberTwo > _numberThree))
        {

            Debug.Log("Los valores están en orden decreciente.");

        }
        else
        {

            Debug.Log("Los valores no están en orden incremdecrecienteental.");

        }

    }
}
