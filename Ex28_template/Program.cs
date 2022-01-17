using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Refrigerator refrigerator = new Refrigerator("冷蔵庫", 50f, 200f, 50f, 80f); //冷蔵庫
            refrigerator.SelfIntroduction();
            Car car = new Car("車", 700f, 200f, 4f); //車
            car.SelfIntroduction();
            Student student = new Student(new DateTime(2002, 12, 15), "デジタル太郎", 90f, 6f, 19f, 16f);　//学生
            student.SelfIntroduction();
            Worker worker = new Worker(DateTime.Now, "デジタル次郎", 90f, 5f, 23f, "サービス業"); //労働者
            worker.SelfIntroduction();
            Fish fish = new Fish(new DateTime(2010, 10, 5), "鮎", 1f, 5f, "川や海"); //魚
            fish.SelfIntroduction();
            Insect insect = new Insect(new DateTime(2020, 1, 10), "カブトムシ", 1f, 0f, 6f); //昆虫
            insect.SelfIntroduction();
            Cat cat = new Cat(DateTime.Now, "ペルシャ", 15f, 12f, "白"); //猫
            cat.SelfIntroduction();
            Dog dog = new Dog(new DateTime(2021, 12, 24), "チワワ", 13f, 15f, "茶色"); //犬
            dog.SelfIntroduction();
            Plant plant = new Plant(new DateTime(2015, 10, 23), "柿の木", 100f, 7f); //植物
            plant.SelfIntroduction();
        }
    }
}
