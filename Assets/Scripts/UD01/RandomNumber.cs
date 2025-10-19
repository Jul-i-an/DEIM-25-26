using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class RandomNumber : MonoBehaviour
{
    
    //Zona de Variables Globales

    [SerializeField]
    private string[] _valueArray = new string[5];     // Variable privada que recibe la cadena de valores

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // Variable local con la posición del array que vamos a recuperar
        int indexArray = Random.Range(0, _valueArray.Length);


        // Inicialiamos el array con 5 mensajes diferentes
        _valueArray[0] = "No te digo trigo por no llamarte Rodrigor.";
        _valueArray[1] = "Está la cosa muy malar qué dise usteer ese hombree.";
        _valueArray[2] = "Tiene musho peligro a wan diodeno a peich ese hombree.";
        _valueArray[3] = "A peich condemor por la gloria de mi madre.";
        _valueArray[4] = "Al ataquerl por la gloria de mi madre.";
        
        
        Debug.Log("El texto del índice del array " + indexArray + "\n" + _valueArray[indexArray]);


    }

}
