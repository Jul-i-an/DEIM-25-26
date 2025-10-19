using UnityEngine;

public class Odd : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // Mostramos los números impares por pantalla
        GetOddNumbers();

    }


    private void GetOddNumbers() 
    {

        // Variables 
        string oddNumbers = "";
        string comma = "";

        for (int i = 0; i <= 100; i++)
        {

            if (i % 2 != 0)
            {

                oddNumbers += comma + i;
                comma = ", ";

            }

        }

        // Mostramos el resultado del script por pantalla
        Debug.Log("Los números impares entre 0 y 100 son :" + oddNumbers);

    }
}
