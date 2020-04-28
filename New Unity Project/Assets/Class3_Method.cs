using UnityEngine;

public class Class3_Method : MonoBehaviour
{
    public person person1; //儲存帶有person類別的物件
    public person person2;

    private void Start()
    {
        // 呼叫person1方法 Talk
        person1.Talk();
        person2.Talk();

        print(person1.gameObject.name+"的BMI:" + person1.BMI());
        print(person2.gameObject.name+"的BMI:" + person2.BMI());

        //使用有參數的方法必須填入對應的引數
        //指定選填式參數 選填式參數名稱:值
        person1.Walk(99,sound: "嘎嘎嘎");
        person2.Walk(10,"左方");

        person1.Attack();
        person2.Attack("劍");
    }
}
