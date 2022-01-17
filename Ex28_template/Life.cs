using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /// <summary>
    /// 生き物
    /// </summary>
    class Life:Thing
    {
        readonly private string _name;
        readonly private DateTime _birthDay = new DateTime();
        public float lifespan;
        public DateTime birthday
        {
            get { return _birthDay; }
        }
        public string name
        {
            get { return _name; }
        }
        public Life(DateTime bd ,string n,float l):base(n)
        {
            this._name = n;
            this._birthDay = bd;
            lifespan = l;
        }
        public void Birthday()
        {
            Console.WriteLine($"誕生日は{birthday.Month}月{birthday.Day}日です。");
        }
        public void BirthdayConfirmation()
        {
            if (DateTime.Now.Month == _birthDay.Month && DateTime.Now.Day == _birthDay.Day)
            {
                Console.WriteLine("今日は誕生日です。");
            }
        }
        public void LifeSpan()
        {
            Console.WriteLine($"寿命は{lifespan}年くらいです。");
        }
    }
}
