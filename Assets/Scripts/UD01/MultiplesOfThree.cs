using UnityEngine;

public class MultiplesOfThree : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // Mostramos los números pares por pantalla
        GetMultiplesOfThreeNumbers();

    }


    private void GetMultiplesOfThreeNumbers()
    {

        // Variables 
        string multiplesOfThreeeNumbers = "";
        string comma = "";

        for (int i = 0; i <= 100; i++)
        {

            if (i % 3 == 0)
            {

                multiplesOfThreeeNumbers += comma + i;
                comma = ", ";

            }

        }

        // Mostramos el resultado del script por pantalla
        Debug.Log("Los números múltiples de 3 entre 0 y 100 son :" + multiplesOfThreeeNumbers);

    }

}
