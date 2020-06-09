using UnityEngine;

public class person : MonoBehaviour
{
    // 給予物件資料
    [Header("身高")]
    public float height;
    [Header("體重")]
    public float weight;
    
    // 定義方法
    // 修飾詞 傳回類型 方法名稱(參數){陳述式}
    // void 無傳回：當使用此方法時不會得到任何傳回資料
    /// <summary>
    /// 讓人講話
    /// </summary>
    public void Talk()
    {
        //gameObject 套用此腳本的物件
        //gameObject.name 套用此腳本物件的名稱
        print("嗨，我在說話～我是"+ gameObject.name); 
    }

    /// <summary>
    /// 計算人的BMI
    /// </summary>
    /// <returns>計算完的BMI</returns>
    public float BMI()
    {
        // 使用result 儲存計算完畢的BMI
        float result = weight/((height/100)*(height/100));
        // 回傳return
        return result;
    }

    //應用參數的走路方法
    // 參數語法:類型　名稱 指定 預設值
    // 有預設值的參數是選填式參數，可填可不填，不填值為預設值
    // 選填式參數必須定義在最右邊
    /// <summary>
    /// 走路方法
    /// </summary>
    /// <param name="speed">需要以多少速度走路</param>
    public void Walk(int speed,string diertion="前方",string sound = "咖咖咖")
    {
        print("用時速" + speed + "公里走路");
        print("走路音效：" + sound);
        print("走路方向：" + diertion);

    }
    // 多載overload
    // 1. 相同名稱的方法
    // 2. 參數數量不同 或者 參數類型不同
    /// <summary>
    /// 徒手攻擊
    /// </summary>
    public void Attack()
    {
        print(gameObject.name + "徒手攻擊!!");
    }
    /// <summary>
    /// 使用武器攻擊
    /// </summary>
    /// <param name="weapon">想要使用的武器</param>
    public void Attack(string weapon)
    {
        print(gameObject.name+"用武器"+weapon+"攻擊!!");
        print("攻擊音效");
    }
    // 讓Unity 按鈕使用方法條件:
    // 1. 修飾詞為公開 public
    // 2. 參數數量小於等於1
    /// <summary>
    /// 技能
    /// </summary>

    public void skill()
    {
        print(gameObject.name + "施放技能!!!");
    }
}
