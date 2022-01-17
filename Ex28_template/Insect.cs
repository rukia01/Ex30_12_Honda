using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Insect:Animal
    {
        public float leg;
        /// <summary>
        /// 昆虫
        /// </summary>
        /// <param name="bd">誕生日</param>
        /// <param name="n">昆虫の種類</param>
        /// <param name="l">寿命</param>
        /// <param name="S">睡眠時間</param>
        /// <param name="le">足の数</param>
        public Insect(DateTime bd, string n, float l = 0, float S = 0, float le = 0) : base(bd, n, l, S)
        {
            leg = le;
        }
        public void SelfIntroduction()
        {
            Console.WriteLine($"昆虫の種類は{name}で、足の数は{leg}本です。");
            Birthday();
            Sleep();
            LifeSpan();
            BirthdayConfirmation();
        }
    }
}
