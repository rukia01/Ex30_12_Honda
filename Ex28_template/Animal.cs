using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Animal : Life
    {
        public float timeOfSleeping;
        public Animal(DateTime bd, string n, float l = 0, float S = 0) : base(bd, n, l)
        {
            timeOfSleeping = S;
        }
        public void Sleep()
        {
            Console.WriteLine($"睡眠時間は約{timeOfSleeping}時間。");
        }
    }
}
