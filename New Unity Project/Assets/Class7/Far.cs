using UnityEngine;

public class Far : Ground
{
    [Header("停止距離"),Range(0,10)]
    public float StopDistance;

    [Header("丟擲物品")]
    public GameObject prop;

    [Header("丟擲間格時間"),Range(0,5)]
    public float cd;
    [Header("死亡時間"),Range(3,7)]
    public float deadTime;
    /// <summary>
    /// 計時器
    /// </summary>
    private float timer;

    /// <summary>
    /// 目標物件
    /// </summary>
    private Transform target;

    private void OnDrawGizmos()
    {
        //圖示.顏色 = 顏色(紅,綠,藍,透明度);
        Gizmos.color = new Color(1, 0, 0, 0.5f);

        //圖示.繪製線條(起點,終點);
        Gizmos.DrawLine(transform.position, transform.position + transform.right * StopDistance);
    }

    private void Start()
    {
        target = GameObject.Find("房紙").transform; //遊戲物件.尋找("物件命稱")變形元件
    }

    private void Awake()
    {
        Physics2D.IgnoreLayerCollision(8, 8); //物理2D忽略圖層碰撞
    }

    protected override void Update()
    {
        base.Update();
        Throw();
    }


    /// <summary>
    /// 丟擲
    /// </summary>
    private void Throw()
    {
        // 距離 = 三維向量.距離(此物件座標,目標座標)
        float dis = Vector3.Distance(transform.position, target.position);
        // 如果距離小於停止距離,就停止
        if(dis<=StopDistance)
        {
            speed = 0;
           

            timer += Time.deltaTime;

            if (timer >= cd)
            {
                timer = 0;
                // 生成(丟擲物品,中心點+右邊+上方,角度)
                GameObject temp = Instantiate(prop, transform.position + transform.right * 2 + transform.up * 2, Quaternion.identity);
                temp.GetComponent<Rigidbody2D>().AddForce(new Vector2(300, 150));
                temp.GetComponent<ThrowObject>().damage = damage;
            }
        }
        Invoke("Explosion",deadTime);
    }

}
