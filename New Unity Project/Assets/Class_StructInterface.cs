using UnityEngine;

public class Class_StructInterface : MonoBehaviour
{
    //Unity 定義的結構struct
    public Vector3 pos;

    // 使用結構
    public Direction myDire1;

    // new新增物件，並且可以使用建構子
    public Direction myDire2 = new Direction(4);

    private void Start()
    {
        // 使用結構成員
        // 三維向量結構 方法成員
        pos.Set(1, 2, 3);

        // 三維向量結構 方法成員
        print("X座標" + pos.x);

        //指定結構成員
        myDire1.direction = 1;

        // 常數與靜態取得用法是一樣的
        print("方向右邊的值：" + Direction.right);

        //錯誤：不能變更常數
        //Direction.left = 5;

        myDire1.Set("左");
        print("方向" + myDire1.direction);

        // 透過new新增的方向資訊
        print("第二筆方向資訊"+myDire2.direction);

    }


    // 類別一定要使用new 新增物件
    // 結構可用可不用
    public Class_Data C_data1 = new Class_Data();
    public Class_Data S_data1;

    // 結構.實值型別-傳址
    public Class_Data C_data2 = new Class_Data("50",9999,100);
    public Class_Data C_data3 = new Class_Data("亮亮", 999999, 50);

    // 結構.實值型別-傳值
    public Struct_Data S_data2 = new Struct_Data("50", 9999, 100);
    public Struct_Data S_data3 = new Struct_Data("亮亮", 999999, 50);

    private void Awake()
    {
        C_data1.name = "5050";
        print(C_data1.name);

        S_data1.name = "KID";
        print(S_data1.name);

        C_data2 = C_data3; //C2=C3兩筆資料地址相同
        C_data2.name = "50"; // 修改C2等同於C3

        S_data2 = S_data3;
        S_data2.name = "50"; // 修改C2等同於C3
    }

}
