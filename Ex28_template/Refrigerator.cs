using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Refrigerator:Thing
    {
        /// <summary>
        /// 冷蔵庫
        /// </summary>
        /// <param name="n">名前</param>
        /// <param name="we">重さ</param>
        /// <param name="w">幅</param>
        /// <param name="h">高さ</param>
        /// <param name="d">奥行</param>
        public Refrigerator(string n = null, float we = 0,float w = 0, float h = 0, float d = 0) : base(n, w, h, d, we)
        {

        }
        public void SelfIntroduction()
        {
            Console.WriteLine($"{name}。");
            Weight();
            Volume();
        }
    }
}
