using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Worker:Person
    {
        public string occupation;
        /// <summary>
        /// 労働者
        /// </summary>
        /// <param name="bd">誕生日</param>
        /// <param name="n">労働者の名前</param>
        /// <param name="l">寿命</param>
        /// <param name="S">睡眠時間</param>
        /// <param name="a">年齢</param>
        /// <param name="o">職種</param>
        public Worker(DateTime bd, string n, float l = 0, float S = 0, float a = 0, string o = "無職") : base(bd, n, l, S, a)
        {
            occupation = o;
        }
        new public void SelfIntroduction()
        {
            base.SelfIntroduction();
            Console.WriteLine($"職種は{occupation}。");
        }
    }
}
