using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Fish:Animal
    {
        public string habitat;
        /// <summary>
        /// 魚
        /// </summary>
        /// <param name="bd">誕生日</param>
        /// <param name="n">魚の種類</param>
        /// <param name="l">寿命</param>
        /// <param name="S">睡眠時間</param>
        /// <param name="h">生息地</param>
        public Fish(DateTime bd, string n, float l = 0, float S = 0, string h = "川") : base(bd, n, l, S)
        {
            habitat = h;
        }
        public void SelfIntroduction()
        {
            Console.WriteLine($"{name}は{habitat}に生息しています。");
            Birthday();
            Sleep();
            LifeSpan();
            BirthdayConfirmation();
        }
    }
}
