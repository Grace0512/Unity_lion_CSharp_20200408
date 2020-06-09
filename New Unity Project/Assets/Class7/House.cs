
using UnityEngine;
using UnityEngine.UI;

public class House : MonoBehaviour
{
    [Header("血量"),Range(100,10000)]
    public float HP;

    [Header("血條")]
    public Image hpBar;

    private float hpMax;

    private void Awake()
    {
        hpMax = HP;
    }
    /// <summary>
    /// 接收傷害值
    /// </summary>
    /// <param name="damage"></param>
    public void Damage(float damage)
    {
        HP -= damage;
        hpBar.fillAmount = HP / hpMax; //更新血條
    }


}