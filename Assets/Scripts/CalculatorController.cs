using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using System.Globalization;

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
        calculatorText += "1";
    }

    public void Two()
    {
        calculatorText += "2";
    }

    public void Three()
    {
        calculatorText += "3";
    }

    public void Four()
    {
        calculatorText += "4";
    }

    public void Five()
    {
        calculatorText += "5";
    }

    public void Six()
    {
        calculatorText += "6";
    }

    public void Seven()
    {
        calculatorText += "7";
    }

    public void Eight()
    {
        calculatorText += "8";
    }

    public void Nine()
    {
        calculatorText += "9";
    }

    public void Zero()
    {
        calculatorText += "0";
    }

    public void Plus()
    {
        calculatorText += " " + "+" + " ";
    }

    public void Minus()
    {
        calculatorText += " " + "-" + " ";
    }

    public void Divide()
    {
        calculatorText += " " + "/" + " ";
    }

    public void Multiply()
    {
        calculatorText += " " + "*" + " ";
    }

    public void Point()
    {
        calculatorText += ".";
    }

    public void Delete()
    {
        calculatorText = "";
    }
    public void Equals()
    {
        if (string.IsNullOrWhiteSpace(calculatorText))
            return; // Prevent empty calculation
        string expression = calculatorText.Replace(",", "."); // Ensure dots for decimal numbers
        string[] values = expression.Split(' ');

        List<string> tokens = new List<string>(values);
    
        // First pass: Handle multiplication and division
        for (int i = 0; i < tokens.Count; i++)
        {
            if (tokens[i] == "*" || tokens[i] == "/")
            {
                if (!double.TryParse(tokens[i - 1], NumberStyles.Any, CultureInfo.InvariantCulture, out double left) ||
                    !double.TryParse(tokens[i + 1], NumberStyles.Any, CultureInfo.InvariantCulture, out double right))
                {
                    calculatorText = "Error";
                    return;
                }
                double result = tokens[i] == "*" ? left * right : (right == 0 ? double.NaN : left / right);
                if (double.IsNaN(result))
                {
                    calculatorText = "Error";
                    return;
                }
                tokens[i - 1] = result.ToString(CultureInfo.InvariantCulture);
                tokens.RemoveAt(i); // Remove operator
                tokens.RemoveAt(i); // Remove right operand
                i--; // Step back to reprocess
            }
        }
    
        // Second pass: Handle addition and subtraction
        if (!double.TryParse(tokens[0], NumberStyles.Any, CultureInfo.InvariantCulture, out double sum))
        {
            calculatorText = "Error";
            return;
        }
    
        for (int i = 1; i < tokens.Count; i += 2)
        {
            string op = tokens[i];
            if (!double.TryParse(tokens[i + 1], NumberStyles.Any, CultureInfo.InvariantCulture, out double num))
            {
                calculatorText = "Error";
                return;
            }
        
            sum = op == "+" ? sum + num : sum - num;
        }
    
        calculatorText = sum.ToString(CultureInfo.InvariantCulture);
    }

}
