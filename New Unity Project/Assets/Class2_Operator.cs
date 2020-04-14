using UnityEngine;

public class Class2_Operator : MonoBehaviour
{
    public float a = 10;
    public float b = 3;
    public string c = "7";
    public int d = 3;
    
    public int e = 99;
    public int f = 9;

    public bool g = true;
    public bool h = false;

    public int key;
    public int result;

    public int hp = 100;

    // 事件：開始事件-播放遊戲時執行一次，處理遊戲初始事件
    private void Start()
    {
        #region 數學運算子
        //數學運算子：加+減-乘*除/餘%
        print(a + b);
        print(a - b);
        print(a * b);
        print(a / b);
        print(a % b); //兩個數值相除剩下的值

        //加法：串接字串與其他資料，結果為字串
        print("分數:"+99.9f);
        // 將字串與數值類型串接再一起不會運算，結果為字串
        print(c + d);
        #endregion

        #region 比較運算子
        // 比較運算子:大於>、小於<、大於等於>=、小於等於<=、等於==、不等於!=
        print(e > f);
        print(e < f);
        print(e >= f);
        print(e <= f);
        print(e == f);
        print(e != f);
        #endregion

        #region 邏輯運算子
        //邏輯運算子：結果為布林值，比較兩個布林值
        // &&：and只要有一個條件false結果就為false
        print("並且"+(g&&h));
        print(true&&true);
        print(true&&false);
        print(false&&true);
        print(false&&false);

        // || ：or 只要有一個true結果就為true
        print("或者"+(g||h));
        print(true||true);
        print(true||false);
        print(false||true);
        print(false || false);

        // 顛倒運算子：加在布林值前，將布林值改為顛倒的結果(EX: !true)
        print(!true);
        print(!false);

        #endregion

        #region 遞增運算子
        // 指定運算子 = 右邊先運算在指定給左邊
        result = 2 + 3;
        print(result);

        key = key + 1;
        print("鑰匙:"+key);

       

        //後製遞增++：先輸出在遞增

        print("鑰匙數量" + key++);

        //前製遞增：先遞增在輸出
        print("鑰匙數量" + ++key);

        #endregion

        #region 複合指派運算子
        // 複合指派運算子：適用於+-*/%

        hp += 20; //hp = hp + 20;
        print("血量:" + hp);

        hp -= 50; //hp = hp - 50;
        print("血量" + hp);

        hp /= 10; // hp = hp / 10
        print("血量" + hp);

        hp %= 2; // hp = hp % 2
        print("血量" + hp);
        #endregion

    }
}
