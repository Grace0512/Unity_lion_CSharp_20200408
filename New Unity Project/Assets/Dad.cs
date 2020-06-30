using UnityEngine;

namespace Class9
{
    public class Dad : MonoBehaviour
    {
        public Boy boy;
        void Start()
        {
            boy.OnNoMoney += HitBoy;
            boy.OnNoMoney += GiveMoney;
        }

        private void GiveMoney()
        {
            boy.money += 10;
            print("給你砸摳");
        }
        
        private void HitBoy()
        {
            print("小屁孩XD");
        }
    }
}


