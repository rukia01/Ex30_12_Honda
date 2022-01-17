using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Dog:Animal
    {
        public string hairColor;
        /// <summary>
        /// 犬
        /// </summary>
        /// <param name="bd">誕生日</param>
        /// <param name="n">犬種</param>
        /// <param name="l">寿命</param>
        /// <param name="S">睡眠時間</param>
        /// <param name="ha">犬の色</param>
        public Dog(DateTime bd, string n, float l = 0, float S = 0, string ha = "黒") : base(bd, n, l, S)
        {
            hairColor = ha;
        }
        public void SelfIntroduction()
        {
            Console.WriteLine($"犬の種類は{name}。色は{hairColor}です。");
            Birthday();
            Sleep();
            LifeSpan();
            BirthdayConfirmation();
        }
    }
}
