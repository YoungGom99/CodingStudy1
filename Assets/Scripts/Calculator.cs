using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    public TMP_Text upperTxt;
    public TMP_Text numberTxt;
    string contents;

    private void Start()
    {
        upperTxt.text = "";
        numberTxt.text = "0";
    }

    string number;
    string nowOper = "+";
    float result;

    public void EnterNumber(string num) // 521
    {
        number += num;    
    }

    //public void EnterOper(string oper)
    //{
    //    print(number + oper);
    //    nowOper = oper;
    //    float num = 0;
    //    switch (oper)
    //    {
    //        case "+":
    //            num = float.Parse(number);
    //            result = Util.Add(result, num);
    //            break;
    //        case "-":
    //            num = float.Parse(number);
    //            result = Util.Subtract(result, num);
    //            break;
    //        case "*":
    //            num = float.Parse(number);
    //            result = Util.Multiply(result, num);
    //            break;
    //        case "/":
    //            num = float.Parse(number);
    //            result = Util.Divide(result, num);
    //            break;
    //    }

    //    number = "";
    //}

    //public void Calculate()
    //{
    //    print(number);
    //    float num = 0;
    //    switch (nowOper)
    //    {
    //        case "+":
    //            num = float.Parse(number);
    //            result = Util.Add(result, num);
    //            break;
    //        case "-":
    //            num = float.Parse(number);
    //            result = Util.Subtract(result, num);
    //            break;
    //        case "*":
    //            num = float.Parse(number);
    //            result = Util.Multiply(result, num);
    //            break;
    //        case "/":
    //            num = float.Parse(number);
    //            result = Util.Divide(result, num);
    //            break;
    //    }

    //    print("결과: " + result);
    //    number = "";
    //    result = 0;
    //}

    //public void EnterNumber(int number)
    //{
    //    numberTxt.text = "";

    //    contents = contents + number.ToString(); // 123

    //    numberTxt.text = contents.ToString();

    //    print(contents);
    //}

    //bool isOperClicked = false;
    //float result;
    //// + - * / = 입력시 text1에 출력
    //public void EnterOperator(string oper)
    //{
    //    contents = numberTxt.text + oper; // 123+

    //    switch(oper)
    //    {
    //        case "+":
    //            break;
    //        case "=":

    //            break;
    //    }
    //    upperTxt.text = contents;
    //    print(contents);
    //}
}
