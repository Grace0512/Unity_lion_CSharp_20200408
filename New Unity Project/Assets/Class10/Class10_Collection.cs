using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Class10
{
    public class Class10_Collection : MonoBehaviour
    {
        #region List ArrayList
        // 陣列:一但固定長度就不能改變
        //public int[] scores = { 100, 90, 80, 70, 60 };

        // 集合:彈性
        // 清單
        public List<float> hp = new List<float> { 99.9f, 88.8f, 77.7f };
        public List<float> hpResule = new List<float>();

        public ArrayList numbers = new ArrayList();

        // 排序
        public List<int> count = new List<int> { 9, 100, 15, 77, 30, 999, 123 };

        private void Start()
        {
            // 1. 集合可以改變長度
            hp.Add(66.6f);      //清單.增加(T);
            hp.Remove(88.8f);   //清單.刪除(T);
           print("是否包含66.6:" +hp.Contains(66.6f)); //是否包含(T)

            hp.FindAll((x) => x >= 70f);  // 搜尋所有(大於等於70)資料

            // ArrayList 與List差異
            // 1. ArrayList為object型別,可存放所以類型
            // 2. List為泛型: 一但指定類型就只能存放一種類型 List<int> - int
            // ArrayList不會顯示在屬性面板上
            numbers.Add(100);
            numbers.Add(77.7f);
            numbers.Add("123");
            numbers.Add(true);

            count.Sort();   //由小到大
            count.Reverse(); //反轉

          
        }
        #endregion

        #region 佇列與堆疊
        // 佇列
        // 1. 添加資料到尾端
        // 2. 先進先出
        public Queue<int> lv = new Queue<int>();

        // 堆疊
        // 1. 添加資料到頂端
        // 2. 先進後出
        public Stack<int> n = new Stack<int>();
        public Queue<string> people = new Queue<string>();
        public Stack<string> box = new Stack<string>();

        private void Awake()
        {
            lv.Enqueue(10);         //添加佇列資料
            lv.Enqueue(20);
            lv.Enqueue(30);

            foreach(var item in lv)
            {
                print("柱列的第一筆資料" + item);
            }


            n.Push(10);             //添加堆疊資料
            n.Push(20);
            n.Push(30);

            foreach(var item in n)
            {
                print("堆疊的資料" + item);
            }

            people.Enqueue("亮亮");
            people.Enqueue("50");
            people.Enqueue("KID");

            box.Push("盒子1號");
            box.Push("盒子2號");
            box.Push("盒子3號");



        }

        private void Update()
        {
            //佇列 先進先出
            if (Input.GetKeyDown(KeyCode.Alpha1)) print("排隊的第一個人:"+people.Dequeue());
            //堆疊 先進後出
            if (Input.GetKeyDown(KeyCode.Alpha2)) print("堆放的第一個箱子:"+box.Pop());
        }
        #endregion

        #region 雜湊表、字典
        // 兩個關鍵字
        // Key、Value - 關鍵字、值

        // 差異
        // 雜湊表 - 物件
        // 字典 - 泛型
        // 雜湊表
        public Hashtable player = new Hashtable();

        // 字典 - 關鍵字(字串),值(整數)
        public Dictionary<string, int> data = new Dictionary<string, int>();

        // 物件啟動時執行事件
        private void OnEnable()
        {
            player.Add("LV", 99);
            player.Add("HP", 9999);
            player.Add("MP", 500);


            // DictionaryEntry 結構 - 儲存Key與Value
            foreach (DictionaryEntry item in player)
            {
                print("雜湊表資料KEY：" + item.Key);
                print("雜湊表資料VALUE：" + item.Value);
            }

            data.Add("短刀", 30);
            data.Add("長刀", 300);
            data.Add("屠龍刀", 30000);
            // data.Add(true,true); //hji4j4
            foreach (KeyValuePair<string,int> item in data)
            {
                print("字典資料KEY：" + item.Key);
                print("字典資料VALUE：" + item.Value);

            }
            // 用陣列或清單存取資料只能透過索引值index
            // 用雜湊表與字典可以使用Key存取資料
            print("價格:"+data["屠龍刀"]);
            print("等級:"+player["LV"]);
        }


        #endregion
    }
}

