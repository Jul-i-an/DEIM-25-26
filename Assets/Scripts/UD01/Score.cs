using UnityEngine;

public class Score : MonoBehaviour
{
    //Zona de Variables Globales

    [SerializeField]
    private int _numberOne;     // Variable privada que recibe el n�mero

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // Llamamos al m�todo de substraci�n
        GetScore();

    }

    // Update is called once per frame
    private void GetScore()
    {

        if (_numberOne >= 45) 
        {

            // Valoramos si el jugador ha llegado a la puntuaci�n indicada
            Debug.Log("Puntuaci�n conseguida.");

        }
        else
        {

            // Valoramos si el jugador ha llegado a la puntuaci�n indicada
            Debug.Log("Puntuaci�n no alcanzada.");

        }

    }

}
