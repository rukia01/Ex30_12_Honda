using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Car:Thing
    {

        public float maximumSpeed;
        public float numberOfPeople;
        /// <summary>
        /// 車
        /// </summary>
        /// <param name="n">車の車種</param>
        /// <param name="we">重さ</param>
        /// <param name="maxS">最高時速</param>
        /// <param name="p">最大乗車人数</param>
        public Car(string n = null, float we = 0, float maxS = 0, float p = 0) : base(n, we)
        {
            maximumSpeed = maxS;
            numberOfPeople = p;
        }
        public void SelfIntroduction()
        {
            Console.WriteLine($"{name}。{numberOfPeople}人乗り。最高時速{maximumSpeed}km。");
            Weight();
        }
    }
}
