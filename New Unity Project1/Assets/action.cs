using UnityEngine;
using UnityEngine.UI;


public class action : MonoBehaviour
{
    /// <summary>
    /// 蝙蝠血量
    /// </summary>
    public bat bat;
    /// <summary>
    /// 史萊姆血量
    /// </summary>
    public bat mons;

    [Header("輸出結果")]
    public Text result;

    /// <summary>
    /// 蝙蝠攻擊
    /// </summary>
    public void bat_attack()
    {
        mons.HP -= bat.attack;

        result.text = "受到蝙蝠攻擊:" + bat.attack + "\n" + "史萊姆剩餘血量:" + mons.HP;



    }
    /// <summary>
    /// 史萊姆攻擊
    /// </summary>
    public void mons_attack()
    {
        
        bat.HP -= mons.attack;

        result.text = "受到史萊姆攻擊:" + mons.attack + "\n" + "蝙蝠剩餘血量:" + bat.HP;
    }

    /// <summary>
    /// 蝙蝠治癒
    /// </summary>
    public void bat_healing()
    {
        bat.HP += bat.healing;

        result.text = "蝙蝠使用治癒:" + bat.healing +"\n"+ "蝙蝠剩餘血量:" + bat.HP;
    }

    /// <summary>
    /// 史萊姆治癒
    /// </summary>
    public void mons_healing()
    {
        mons.HP += mons.healing;

        result.text = "史萊姆使用治癒:" + mons.healing+"\n" + "史萊姆剩餘血量:" + mons.HP;
    }



}
