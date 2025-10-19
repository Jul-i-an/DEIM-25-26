using Unity.VisualScripting;
using UnityEngine;

public class Week : MonoBehaviour
{

    //Zona de variables globales
    [SerializeField]
    private int _dayOfWeek; // Variable privada que recibe el n�mero del d�a de la semana

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        GetNameOfDay();

    }

    private void GetNameOfDay()
    {

        string nameOfDay = "";
        // Seleccionamos el d�a de la semana que haya introducido el cliente
        switch (_dayOfWeek)
        {

            case 1: 
                nameOfDay = "El d�a de la semana correspondiente a " + _dayOfWeek + " es lunes";
                break;
            case 2: 
                nameOfDay = "El d�a de la semana correspondiente a " + _dayOfWeek + " es martes";
                break;
            case 3: 
                nameOfDay = "El d�a de la semana correspondiente a " + _dayOfWeek + " es mi�rcoles";
                break;
            case 4: 
                nameOfDay = "El d�a de la semana correspondiente a " + _dayOfWeek + " es jueves";
                break;
            case 5: 
                nameOfDay = "El d�a de la semana correspondiente a " + _dayOfWeek + " es viernes";
                break;
            case 6: 
                nameOfDay = "El d�a de la semana correspondiente a " + _dayOfWeek + " es s�bado";
                break;
            case 7: 
                nameOfDay = "El d�a de la semana correspondiente a " + _dayOfWeek + " es domingo";
                break;
            default:
                nameOfDay = "N�mero inv�lido. Escriba un n�mero entre 1 y 7 (incluidos)";
                break;

        }

        Debug.Log(nameOfDay);

    }

}
