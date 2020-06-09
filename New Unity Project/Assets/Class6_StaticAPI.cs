using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class6_StaticAPI : MonoBehaviour
{
    public Enemy zombie1, zombie2;

    // 修飾詞 非靜態成員類別 物件名稱
    public GameObject obj1;

    public Light myLight;

    public Transform tran1;

    private void Start()
    {
        #region 取得靜態
        print(zombie1.name + "的血量：" + zombie1.hp);
        print(zombie2.name + "的血量：" + zombie2.hp);

        //靜態欄位取得方式：類別.靜態欄位
        // 無法透過物件取得靜態欄位

        print("殭屍的速度：" + Enemy.speed);

        zombie1.Walk();
        zombie2.Walk();

        //使用靜態方法
        // 類別.靜態方法
        Enemy.Stop();
        // 無法透過物件取得靜態方法(錯誤)
        //zombie1.Stop();
        #endregion

        #region 靜態API
        // 存放 靜態 屬性
        // 類別.靜態屬性 = 值
        Cursor.visible = false;

        // 取得 靜態 屬性
        print(Mathf.PI);

        //使用靜態方法
        // 類別.靜態方法(對應的引數)
        print("絕對值：" + Mathf.Abs(-77.7f));

        print("隨機範圍：" + Random.Range(1f, 100f));

        // 整數不傳回最大值 (0~2)
        print("隨機整數："+Random.Range(1,3));
        #endregion

        // 非靜態 屬性
        // 物件名稱.非靜態成員
        print("物件圖層：" + obj1.layer);

        //非靜態須要有實體物件(存在遊戲場景內的物件)
        print("燈光顏色："+myLight.color);
        /// Vector3.one = (1,1,1);
        tran1.localScale = Vector3.one * 5;

    }

    private void Update()
    {
        if(Input.anyKey)
        print("玩家按任意鍵");

        print("玩家是否按空白鍵" + Input.GetKeyDown("space"));

        print("玩家是否按右鍵" + Input.GetKeyDown(KeyCode.Mouse1));

        // 非靜態方法
        // 物件名稱.非靜態方法(對應的引數)
        tran1.Rotate(0,2*Time.deltaTime,0);


    }
}
