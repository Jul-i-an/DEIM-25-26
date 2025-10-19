using UnityEngine;

public class Even : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // Mostramos los números pares por pantalla
        GetEvenNumbers();

    }


    private void GetEvenNumbers()
    {

        // Variables 
        string oddNumbers = "";
        string comma = "";

        for (int i = 0; i <= 100; i++)
        {

            if (i % 2 == 0)
            {

                oddNumbers += comma + i;
                comma = ", ";

            }

        }

        // Mostramos el resultado del script por pantalla
        Debug.Log("Los números pares entre 0 y 100 son :" + oddNumbers);

    }
}
