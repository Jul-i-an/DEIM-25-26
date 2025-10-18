using UnityEngine;

public class HelloWorld : MonoBehaviour
{

    // Zona de variables globales


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // Variables locales
        float x = 3.0f,
              y,
              z = 1.0f;
        x = 2.0f;
        x = Mathf.Pow((x + x), 2);
        x = Mathf.Sqrt(x + Mathf.Sqrt(x) + 5);

        Debug.Log("El resultado es :" + x);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
