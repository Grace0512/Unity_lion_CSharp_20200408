using UnityEngine;

namespace Class9
{
    public class Mom : MonoBehaviour
    {
        public Boy boy;

        private void Start()
        {
            //1. 訂閱事件
            boy.OnNoMoney += GiveMoney;
        }

        //2. 實作方法
        private void GiveMoney()
        {
            print("這個快就花玩ㄌ!!");
            boy.money += 1000;
        }
    }

}

