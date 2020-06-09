using UnityEngine;
using UnityEngine.UI; //引用Unity介面命名空間
using System; //上方引用系統的命名空間，系統API字串轉整數

public class Practice_OperatorMethod : MonoBehaviour
{
    /// <summary>
    /// 第一個數字
    /// </summary>
    public string number1;
    /// <summary>
    /// 第二個數字
    /// </summary>
    public string number2;

    /// <summary>
    /// 輸出結果
    /// </summary>
    [Header("文字:輸出結果")]
    public Text result;

    /// <summary>
    /// 給第一個輸入欄位使用
    /// </summary>
    /// <param name="number">第一個欄位的數值</param>
    public void Inputnumber1(string number)
    {
        number1 = number;
    }
    /// <summary>
    /// 給第二個輸入欄位使用
    /// </summary>
    /// <param name="number">第二個欄位的數值</param>
    public void Inputnumber2(string number)
    {
        number2 = number;
    }

    /// <summary>
    /// 加法運算
    /// </summary>
    public void Add()
    {
        // 將number1 number2目前資料型態是string轉換為int
        int n1 = Int32.Parse(number1);
        int n2 = Int32.Parse(number2);

        print("加法結果:" + (n1 + n2));
        //輸出結果.文字內容
        result.text= "加法結果:"+(n1+n2); 
    }

    /// <summary>
    /// 減法運算
    /// </summary>
    public void subs()
    {
        int n1 = Int32.Parse(number1);
        int n2 = Int32.Parse(number2);

        print("減法結果:" + (n1-n2));

        result.text = "減法結果:" + (n1 - n2);
    }

    /// <summary>
    /// 乘法運算
    /// </summary>
    public void multi()
    {
        int n1 = Int32.Parse(number1);
        int n2 = Int32.Parse(number2);

        print("乘法結果:" + (n1*n2));
        result.text = "乘法結果:" + (n1 * n2);
    }

    /// <summary>
    /// 除法運算
    /// </summary>
    public void division()
    {
        int n1 = Int32.Parse(number1);
        int n2 = Int32.Parse(number2);

        print("除法結果" + (n1/n2));
        result.text = "除法結果:" + (n1 / n2);
    }

    /// <summary>
    /// 餘數運算
    /// </summary>
    public void remainder()
    {
        int n1 = Int32.Parse(number1);
        int n2 = Int32.Parse(number2);

        print("餘數結果" + (n1 % n2));
        result.text = "餘數結果:" + (n1 % n2);
    }
}
