using UnityEngine;
using System.Collections;//引用系統集合API(協同程序)

namespace Class8
{
public class Prop : MonoBehaviour,ICanUse
    {
        public Data data;

        public void Use()
        {
            print("使用道具:" + data.name);

            //啟動協同程序(協成方法)
            StartCoroutine(Big());
        }

        /// <summary>
        /// 協同程序方法：傳回類型IEnumerable
        /// 必須傳回時間
        /// yield return new WaitForSeconds(秒數);
        /// </summary>
        /// <returns></returns>
        private IEnumerator Big()
        {
            Transform player = FindObjectOfType<Player>().transform;

            while(player.lossyScale.x<3)
            {
                player.localScale += Vector3.one * 0.1f;
                yield return new WaitForSeconds(0.01f);
            }

            Destroy(gameObject);

        }

    }
}


