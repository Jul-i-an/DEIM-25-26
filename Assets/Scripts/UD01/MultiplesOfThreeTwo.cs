using UnityEngine;

public class MultiplesOfThreeTwo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // Mostramos los números pares por pantalla
        GetMultiplesOfThreeTwoNumbers();

    }


    private void GetMultiplesOfThreeTwoNumbers()
    {

        // Variables 
        string multiplesOfThreeeTwoNumbers = "";
        string comma = "";

        for (int i = 0; i <= 100; i++)
        {

            if ((i % 2 == 0) && (i % 3 == 0))
            {

                multiplesOfThreeeTwoNumbers += comma + i;
                comma = ", ";

            }

        }

        // Mostramos el resultado del script por pantalla
        Debug.Log("Los números múltiples de 2 y de 3 entre 0 y 100 son :" + multiplesOfThreeeTwoNumbers);

    }
}
