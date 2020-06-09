using UnityEngine;

public class Class5_IFSwitchLoop : MonoBehaviour
{
    
    [Header("是否開門")]
    public bool openDoor;
    [Header("分數")]
    public int score = 0;
    [Header("血量")]
    public int hp = 100;
    [Header("道具")]
    public string prop = "紅水";

    public Day day;

    public Season season;

    [Header("道具數量")]
    public int count;
    [Header("任務是否完成")]
    public bool complete;

    private int i = 1;
    private int j = 1;

    // GameObject 可以存放階層面板或專案內的模型
    [Header("地板")]
    public GameObject cube;

    private int[] scores = { 100, 99, 88, 77, 66, 55 };

    public void CreateFloor(int length,int width)
    {
        // 使用for迴圈取得陣列資料
        for(int i =0;i<scores.Length;i++)
        {
            print("for 迴圈取得資料"+scores[i]);
        }

        //語法: foreach(取得資料的類型 取得資料的名稱 in 陣列){執行次數為陣列數量}
        foreach (int item in scores)
        {
            print("foreach迴圈取得資料"+item);
        }
        // 巢狀迴圈
        // 初始值名稱不能相同
        for (int j=0;j<width;j++)
        {
            for (int i = 0; i < length; i++)
            {
                //api 實例化(生成)
                //生成(物件,座標,角度)
                //  Vector3 三維向量(保存三個浮點數)
                // Quaternion.identity 零角度
                // Quaternion.Euler(270,0,0) (x,y,z) 0~360度
                Instantiate(cube, new Vector3(j*2, 0, i * 2), Quaternion.Euler(270, 0, 0));
            }
        }
        
    }

    private void Start()
    {
        // if 判斷式 
        // if (布林值) {布林值 = true時執行}
        if(true)
        {
            print("ififififif");
        }
    }
    private void Awake()
    {
        /*
        for (int i=0;i<101;i++)
        {
            print("break迴圈外的程式"+i);
            // 如果i等於10就打斷迴圈並且執行迴圈下方的程式
            if (i==10)
            {
                break;
            }
        }

        print("break 迴圈外的程式");*/

        /*for (int i = 0; i < 101; i++)
        {
            print("break迴圈外的程式" + i);
            // 如果i等於10就打斷迴圈並且執行迴圈下方的程式
            if (i == 10)
            {
                return;
            }
        }

        print("return 迴圈外的程式");
        */
        /*for (int i =0; i < 20; i++)
        {
            if (i == 5) continue; // 符合就會continue,不會輸出這一層的值
            print("continue迴圈:"+i);
        }
        print("continue迴圈外的程式");
        */
        // 執行結果 0-4
       for (int i =0; i < 10; i++)
       {
           if (i == 5) goto Test; // 符合就會continue,不會輸出這一層的值
           print("continue迴圈:"+i);
       }
        print("這裡會被執行嗎?"); //不會 XDDD

        Test: //標記名稱
        print("標記陳述式");


      /* CreateFloor(30,5);
       // while 迴圈
       // while (布林值){當布林值為true執行}
       // 迴圈之前評估：第一次判斷　i=1
       while (i<=10)
       {
           print("while迴圈第:"+i+"次");
           i++;
       }
       // 迴圈之後評估：第一次判斷　j=2
       do
       {
           print("do迴圈第:" + j + "次");
           j++;

       } while (j <= 10);

       // for (初始值;條件;迭代器)
       for ( int k = 1 ; k > 0 ; k-- )
       {
           print("for迴圈第:" + k + "次");
       }
       for ( int k = 1; k <= 0; k++ )
       {
           print("for迴圈倒數:" + k + "次");
       }*/
    }
    private void Update()
    {
        //當道具數量 >=5 任務完成true
        //三元運算子語法 - 布林值運算式? 運算式A : 運算式B
        // 指派、呼叫　= 
        complete = count >= 5 ? true : false;

        //test = score >= 60 ? "及格" : score >= 40 ? "補考" : "被當":
        
        // 當openDoor為true 執行{開門}
        // 當openDoor 為false 執行{關門}
        // if (openDoor == true)
        /*
        if(openDoor)
        {
            print("開門");
        }
        else
        {
            print("關門");
        }
        */
        // 大於60 及格
        // 小於60 不及格
        // 一組判斷式只有一個執行結果
        if(score >=60)
        {
            print("及格");        }
        else if(score>=40) //可以無限多個
        {
            print("補考");
        }
        else if(score >= 20)
        {
            print("花錢補考");
        }
        else
        {
            print("被當");
        }
        HP();
        Prop();

    }
    private void HP()
    {
        if(hp>=70)
        {
            print("安全");
        }
        else if(hp>=20)
        {
            print("警告");
        }
        else if(hp>=0)
        {
            print("危險");
        }
    }
    private void Prop()
    {
        switch(prop)
        {
            case "紅水":
                print("補HP");
                break;
            case "藍水":
                print("補MP");
                break;
            case "黃水":
                print("補EXP");
                break;
            default: //如果不想寫可以省略
                print("吃錯道具~");
                break;
        }



        switch (day)
        {
            case Day.Sunday:
                break;
            case Day.Monday:
                break;
            case Day.Tuesday:
                break;
            case Day.Wensday:
                break;
            case Day.Thursday:
                break;
            case Day.Friday:
                break;
            case Day.Saturday:
                break;
            default:
                break;
        }
        switch (season)
        {
            case Season.Spring:
                break;
            case Season.Summer:
                break;
            case Season.Fall:
                break;
            case Season.Winter:
                break;
            default:
                break;
        }
    }

}
