using UnityEngine;

public class Logic : MonoBehaviour
{
    //Zona de Variables Globales

    [SerializeField]
    private bool[] _valueArray = new bool[] {false, false, false };     // Variable privada que recibe el número

    void Start()
    {

        // Cambiamos el primer valor del "array" a true
        _valueArray[0] = true;

        // Procedemos a recorrer y mostrar los valores del "array"
        for (int i = 0; i < _valueArray.Length; i++) 
        {

            Debug.Log("El valor de la posición " + i + " del array es: " + _valueArray[i]);

        }


    }


}
