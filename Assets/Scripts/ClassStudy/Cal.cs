using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Cal : MonoBehaviour
{
    public TMP_Text upperTxt;
    public TMP_Text numberTxt;
    List<string> operOrder = new List<string>();
    bool isOperClicked = false;
    bool isCalculated = false;

    private void Start()
    {
        numberTxt.text = "0";
        upperTxt.text = string.Empty;
    }

    public void OnNumBtnClkEvent(string num)
    {
        if (numberTxt.text == "0")
            numberTxt.text = string.Empty;

        if (isCalculated)
        {
            numberTxt.text = string.Empty;
            upperTxt.text = string.Empty;
            isCalculated = false;
        }

        if (isOperClicked)
        {
            numberTxt.text = string.Empty;
            isOperClicked = false;
        }

        numberTxt.text += num;
    }

    public void OnOperClkEvent(string oper)
    {
        isOperClicked = true;

        if (isCalculated)
        {
            operOrder.Add(oper);
            upperTxt.text += $"{oper}";
            isCalculated = false;
            return;
        }
        else
        {
            operOrder.Add(oper); // 12 + 3 -> +(0)
            upperTxt.text += $"{numberTxt.text}{oper}";
        }
    }

    public void OnCalBtnClkEvent()
    {
        isCalculated = true;

        upperTxt.text += numberTxt.text;

        char[] opers = { '+', '-', 'x', '¡À' };
        string[] strings = upperTxt.text.Split(opers); // 12 + 3 + 1 -> A{12, 3, 1}   B{+, +}
        double[] numbers = new double[strings.Length];
        // if(B[i] == "+")
        //  result = A[i] + A[i+1]
        // else if(B[i] == "-")
        //  result = A[i] - A[i+1]

        for (int i = 0; i < strings.Length; i++)
        {
            numbers[i] = double.Parse(strings[i]);
        }

        double result = numbers[0];
        for (int i = 0; i < operOrder.Count; i++)
        {
            if (numbers.Length == (i + 1))
                break;

            switch (operOrder[i])
            {
                case "+":
                    result += numbers[i + 1];
                    break;
                case "-":
                    result -= numbers[i + 1];
                    break;
                case "x":
                    result *= numbers[i + 1];
                    break;
                case "¡À":
                    result /= numbers[i + 1];
                    break;
                default:
                    Console.WriteLine("Unknown operator: " + opers[i]);
                    break;
            }
        }

        numberTxt.text = result.ToString();
    }

    public void OnClearBtnClkEvent()
    {
        numberTxt.text = "0";
        upperTxt.text = string.Empty;
        operOrder.Clear();
    }

    public void OnDelBtnClkEvent()
    {
        if (numberTxt.text.Length < 1)
            return;

        int lastIndex = numberTxt.text.Length - 1;
        numberTxt.text = numberTxt.text.Substring(0, lastIndex);
    }
}