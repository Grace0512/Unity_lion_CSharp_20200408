using UnityEngine;

public class Class9_DelegateEvent : MonoBehaviour
{
   public void AddTen(int number)
    {
        int n = number += 10;
        print("數字累加："+n);
    }

    private void Awake()
    {
        AddTen(10);
    }

    public void MethodA()
    {
        print("我是方法A");
    }
    public void MethodB()
    {
        print("我是方法B");
    }

    //簽名：無傳回、一個字串參數
    public void MethodC(string msg)
    {
        print("我是方法C - "+msg);
    }

    // 定義委派
    // 可以儲存無傳回、無參數的任何方法
    // ※ 簽名：方法的傳回類型、參數類型與參數數量。
    public delegate void DelegateTest();
    public delegate void DelegateTest2(string s);
    // 委派的簽名：無傳回、一個參數、整數
    public delegate void DelegateTest3(int number);



    //定義委派欄位
    public DelegateTest dA;
    public DelegateTest dB;
    public DelegateTest2 dC;
    public DelegateTest d;
    public DelegateTest d2;

    public DelegateTest3 d3;

    private void Start()
    {
        dA = MethodA; //dA欄位儲存 方法A
        dA();         // 呼叫dA

        dB = MethodB;
        dB();

        dC = MethodC; //儲存方法C
        dC("委派C"); //方法C需要傳參數

        d = MethodA;
        d += MethodB;

        // Lambda 匿名函式
        // () => { 陳述式 }
        d += () => 
        { 
            print("我是匿名函式哦1~");
            print("我是匿名函式哦2~");
        };

        d();

        d3 = (n) => { n *= 10; print("十倍後的數值"+n); };

        d3(7);

    }


}
