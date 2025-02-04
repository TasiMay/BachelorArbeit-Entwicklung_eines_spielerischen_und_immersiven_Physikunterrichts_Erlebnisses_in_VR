using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CalculatorController : MonoBehaviour
{
    public string calculatorText = "";
    public TMP_Text textField;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textField.text = calculatorText;
    }

    public void One()
    {
        calculatorText += "1" + " ";
    }

    public void Two()
    {
        calculatorText += "2" + " ";
    }

    public void Three()
    {
        calculatorText += "3" + " ";
    }

    public void Four()
    {
        calculatorText += "4" + " ";
    }

    public void Five()
    {
        calculatorText += "5" + " ";
    }

    public void Six()
    {
        calculatorText += "6" + " ";
    }

    public void Seven()
    {
        calculatorText += "7" + " ";
    }

    public void Eight()
    {
        calculatorText += "8" + " ";
    }

    public void Nine()
    {
        calculatorText += "9" + " ";
    }

    public void Zero()
    {
        calculatorText += "0" + " ";
    }

    public void Plus()
    {
        calculatorText += "+" + " ";
    }

    public void Minus()
    {
        calculatorText += "-" + " ";
    }

    public void Divide()
    {
        calculatorText += "/" + " ";
    }

    public void Multiply()
    {
        calculatorText += "*" + " ";
    }

    public void Point()
    {
        calculatorText += "," + " ";
    }

    public void Delete()
    {
        calculatorText = "";
    }

    public void Equals()
    {
        
    }
}
