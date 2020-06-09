using UnityEngine;

public class ThrowObject : MonoBehaviour
{
    [Header("爆炸效果")]
    public GameObject explosion;

    [Header("傷害值"),Range(10,500)]
    public float damage;

    protected void Explosion()
    {
        // 生成爆炸效果
        GameObject exp = Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
        Destroy(exp, 2.5f);
    }

   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "房紙")
        {
            collision.gameObject.GetComponent<House>().Damage(damage);
            Explosion();
        }
    }
}
