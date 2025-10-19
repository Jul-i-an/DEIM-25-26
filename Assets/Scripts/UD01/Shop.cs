using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField]
    private int _stockOfPotatoes,           // Variable privada con la cantidad de patatas
                _stockOfBroccoli,           // Variable privada con la cantidad de brocoli
                _quantityPotatoes,          // Variable privada que recibe la cantidad
                _quantityBrocoli;           // Variable privada que recibe la cantidad

    [SerializeField]
    private bool _addBrocolli = false,      // Variable privada opción agregar brocoli
                 _removeBrocolli = false,   // Variable privada opción eliminar brocoli
                 _addPotatoes = false,      // Variable privada opción agregar patatas
                 _removePotatoes = false;   // Variable privada opción agregar patatas

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // Mostramos el stock inicial brocoli y patatas
        Debug.Log("El stock inial es: \n - Brocoli: " + _stockOfBroccoli + " - Patatas: " + _stockOfPotatoes);

        // Si está marcado agregar Brocoli, llamamos a aumentar la cantidad de brocoli
        if (_addBrocolli)
        {

            Debug.Log("Agregamos " + _quantityBrocoli + " unidades al stock de brocoli.");
            AddQuantityOfBrocolli();

        }

        // Si está marcado eliminar Brocoli, llamamos a reducir la cantidad de brocoli
        if (_removeBrocolli)
        {

            Debug.Log("Retiramos " + _quantityBrocoli + " unidades del stock de brocoli.");
            DeleteQuantityOfBrocolli();

        }        

        // Si está marcado agregar Patatas, llamamos a aumentar la cantidad de patatas
        if (_addPotatoes)
        {

            Debug.Log("Agregamos " + _quantityPotatoes + " unidades al stock de patatas.");
            AddQuantityOfPotatoes();

        }

        // Si está marcado eliminar Patatas, llamamos a reducir la cantidad de patatas
        if (_removePotatoes)
        {

            Debug.Log("Retiramos " + _quantityPotatoes + " unidades del stock de patatas.");
            DeleteQuantityOfPotatoes();

        }

        // Mostramos el stock Final del brocoli y patatas
        Debug.Log("El stock final es: \n - Brocoli: " + _stockOfBroccoli + " - Patatas: " + _stockOfPotatoes);

    }

    private void AddQuantityOfBrocolli() 
    {

        // Reducimos la cantidad de brócoli indicado por el usuario
        _stockOfBroccoli -= _quantityBrocoli;

    }
    
    private void DeleteQuantityOfBrocolli()
    {

        // Aumentamos la cantidad de brócoli indicado por el usuario
        _stockOfBroccoli += _quantityBrocoli;

    }
    
    private void AddQuantityOfPotatoes()
    {

        // Reducimos la cantidad de patatas indicado por el usuario
        _stockOfPotatoes -= _quantityPotatoes;

    }
    
    private void DeleteQuantityOfPotatoes()
    {

        // Aumentamos la cantidad de patatas indicado por el usuario
        _stockOfPotatoes += _quantityPotatoes;

    }
}
