﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Plant : Life
    {
        public float growthDays;
        /// <summary>
        /// 植物
        /// </summary>
        /// <param name="bd">誕生日</param>
        /// <param name="n">植物の名前</param>
        /// <param name="l">寿命</param>
        /// <param name="gD">成長日数</param>
        public Plant(DateTime bd, string n, float l = 0, float gD = 0) : base(bd, n, l)
        {
            growthDays = gD;
        }
        public void SelfIntroduction()
        {
            Console.WriteLine($"{name}は、約{growthDays}年で成長します。");
            Birthday();
            LifeSpan();
            BirthdayConfirmation();
        }
    }
}
