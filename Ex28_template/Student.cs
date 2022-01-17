using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Student:Person
    {
        public float id;
        /// <summary>
        /// 学生
        /// </summary>
        /// <param name="bd">誕生日</param>
        /// <param name="n">学生の名前</param>
        /// <param name="l">寿命</param>
        /// <param name="S">睡眠時間</param>
        /// <param name="a">年齢</param>
        /// <param name="i">学籍番号</param>
        public Student(DateTime bd, string n, float l = 0, float S = 0, float a = 0, float i = 0) : base(bd, n, l, S, a)
        {
            id = i;
        }
        new public void SelfIntroduction()
        {
            base.SelfIntroduction();
            Console.WriteLine($"学籍番号は{id}。");
        }
    }
}
