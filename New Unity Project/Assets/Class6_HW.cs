using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class6_HW : MonoBehaviour
{
    public SpriteRenderer KIDImage;

    public Rigidbody RbSphere;
    
    void Start()
    {
        // 第一題：設定時間為兩倍
        Time.timeScale = 2f;
        // 第二題：翻轉圖片
        KIDImage.flipX = true;
        // 第三題：去小數點
        print("去小數點：" + Mathf.Floor(1.23456f));
        // 第四題：添加推力

        RbSphere.AddForce(0,800,1200);



    }

    
    void Update()
    {
        
    }
}
