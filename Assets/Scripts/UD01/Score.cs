using UnityEngine;

public class Score : MonoBehaviour
{
    //Zona de Variables Globales

    [SerializeField]
    private int _numberOne;     // Variable privada que recibe el número

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // Llamamos al método de substración
        GetScore();

    }

    // Update is called once per frame
    private void GetScore()
    {

        if (_numberOne >= 45) 
        {

            // Valoramos si el jugador ha llegado a la puntuación indicada
            Debug.Log("Puntuación conseguida.");

        }
        else
        {

            // Valoramos si el jugador ha llegado a la puntuación indicada
            Debug.Log("Puntuación no alcanzada.");

        }

    }

}
