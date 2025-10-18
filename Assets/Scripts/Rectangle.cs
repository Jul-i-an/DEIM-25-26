using UnityEngine;

public class Rectangle : MonoBehaviour
{
    // Global variable Zone

    private float _width;
    private float _height;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // Variable initialitation
        _width = 12.5f;
        _height = 6.1f;

        // Call to GetArea Method
        GetArea();

        // Call to GetPerimeter Method
        GetPerimeter();

        // Call to GetDiagonal Method
        GetDiagonal();



    }

    private void GetArea() 
    {

        // Local variable
        float area = 0.0f;

        //Area calculation
        area = _width * _height;

        // Show information into console
        Debug.Log("El área del rectángulo es: " + area);

    }

    private void GetPerimeter() 
    { 
    
        // Local variable
        float perimeter = 0.0f;

        // Perimeter calculation
        perimeter = 2 * (_width * _height);

        // Show information into console
        Debug.Log("El perímetro del rectángulo es: " + perimeter);

    }

    private void GetDiagonal()
    {

        // Local variable
        float diagonal = 0.0f;

        // Longitud calculation
        diagonal = Mathf.Sqrt(Mathf.Pow(_width, 2) + Mathf.Pow(_height, 2));

        // Show information into console
        Debug.Log("El perímetro del rectángulo es: " + diagonal);

    }

}
