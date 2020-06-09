using UnityEngine;
public enum Season
{
    Spring, Summer, Fall, Winter
}

public enum State
{
    Idle, Walk, Attack, Damage, Skill, Dead
}

public enum Day
{
    Sunday = 7 , Monday = 1, Tuesday, Wensday,Thursday,Friday,Saturday
}

public class Class4 : MonoBehaviour
{
    // 使用列舉
    // 修飾詞 列舉名稱 自訂名稱
    public Season _season;
    public State _state;
    public Day _day = Day.Wensday;

    // 喚醒事件：Start 之前執行一次
    private void Awake()
    {
        // 取得列舉
        print("季節:"+ _season);
        print("狀態:"+(int)_state);
        print("日期:" + (int)_day);
        _state = State.Walk;
    }

    public ship ship;
    public string name1 = "KID";
    // 屬性面板上的size是數量 element 為陣列成員 編號從0開始
    public string[] names; //宣告陣列不指定數量

    public float[] weights = new float[3]; //宣告陣列並指定數量

    public int[] scores = new int[] {10,20,30,40}; // 宣告陣列並指定內容

    public bool[] missoon = { true, false, false };// 宣告陣列並指定內容
    
    private void Start()
    {
        //設定屬性
        ship.length = 99.9f;
        //取得屬性
        print(ship.length);
        // 無法設定唯獨屬性
        //ship.width = 20.5f; //錯誤
        // 取得唯獨屬性
        print("船的寬度："+ship.width);

        ship.atk = 50.3f;

        print("船的攻擊力"+ship.atk);
        print("船的防禦力"+ship.def);

        names = new string[] {"怪物A","怪物B","怪物C" };

        //陣列[編號] - 編號從0開始
        //陣列存放
        scores[0] = 77;
        //陣列取得
        print("取得怪物陣列第三筆資料"+name[1]);
        //陣列常見錯誤：編號超出範圍
        // IndexOutOfRangeException

        //陣列.Length 長度(數量)
        print("分數陣列的長度(數量)"+scores.Length);

        // 呼叫改變分數方法並將分數陣列傳進方法內
        ChangScore(scores);

        TestValue(A);
        TestRefe(B);

    }

    // 陣列為參考型別
    /// <summary>
    /// 改變第二筆分數
    /// </summary>
    private void ChangScore(int[] theArray)
    {
        theArray[1] = 99;
    }

    // 整數為實質型別
    public int A = 99;
    //陣列為參考型別
    public int[] B = {99};

    /// <summary>
    /// 測試實質型別，當引數時傳值，不會修改原本資料。
    /// </summary>
    /// <param name="test"></param>
    private void TestValue(int test)
    {
        test = 0;
    }
    /// <summary>
    /// 測試參考型別，當引數傳址，會修改原本資料
    /// </summary>
    /// <param name="test"></param>
    private void TestRefe(int[] test)
    {
        test[0] = 0;
    }
}
