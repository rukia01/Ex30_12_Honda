﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Person:Animal
    {
        public float age;
        /// <summary>
        /// 人
        /// </summary>
        /// <param name="bd">誕生日</param>
        /// <param name="n">人の名前</param>
        /// <param name="l">寿命</param>
        /// <param name="S">睡眠時間</param>
        /// <param name="a">年齢</param>
        public Person(DateTime bd, string n, float l = 0, float S = 0, float a = 0) : base(bd, n, l, S)
        {
            age = a;
        }
        public void SelfIntroduction()
        {
            Console.WriteLine($"名前は{name}です。年齢は{age}歳です。");
            Birthday();
            Sleep();
            LifeSpan();
            BirthdayConfirmation();
        }
    }
}
