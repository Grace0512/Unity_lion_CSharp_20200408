using UnityEngine;

public class MonsterManger : MonoBehaviour
{
    [Header("怪物陣列 0狐狸 1老鷹 2神祕生物 3呱")]
    public GameObject[] monster;

    /// <summary>
    /// 生成怪物
    /// </summary>
    /// <param name="index">怪物指標0狐狸 1老鷹 2神祕生物 3呱</param>
    public void CraeteMonster(int index)
    {
        Instantiate(monster[index], new Vector3(-10, 2, 0), Quaternion.identity);
    }
}
