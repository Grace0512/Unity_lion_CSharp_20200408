using UnityEngine;
/// <summary>
/// 怪物的基底類別
/// </summary>
public class Monster : MonoBehaviour
{
    [Header("移動速度"),Range(0,10)]
    public float speed;

    [Header("傷害值"),Range(10,500)]
    public float damage;

    [Header("爆炸效果")]
    public GameObject explosion;

    protected void Move()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    protected void Explosion()
    {
        // 生成爆炸效果
        GameObject exp = Instantiate(explosion,transform.position,Quaternion.identity);
        Destroy(gameObject);
        Destroy(exp, 2.5f);
    }

    protected virtual void Update()
    {
        Move();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "房紙")
        {
            collision.gameObject.GetComponent<House>().Damage(damage);
            Explosion();
        }
    }
}
