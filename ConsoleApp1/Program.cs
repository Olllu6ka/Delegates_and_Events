using System;

namespace ConsoleApp1
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону Console Application.
        //Создайте программу, в которой создайте анонимный метод, который принимает в качестве
        //аргумента массив делегатов и возвращает среднее арифметическое возвращаемых значений
        //методов сообщенных с делегатами в массиве.Методы, сообщенные с делегатами из массива,
        //возвращают случайное значение типа int.
        public delegate int MyAnonimmetod();
        public delegate int MyAverage(MyAnonimmetod [] arrayX);
        static Random random = new Random();
        public static int Randomizer() => random.Next(1, 10);
        static void Main(string[] args)
        {
            MyAnonimmetod[] ArrayAnonimMetod = new MyAnonimmetod[10];
            for (int i = 0; i < ArrayAnonimMetod.Length; i++)
            {
                ArrayAnonimMetod[i] = Randomizer;
            }
            MyAverage myAverage = delegate (MyAnonimmetod[] arrayX)
            {
                int result = 0;
                for (int i = 0; i < arrayX.Length; i++)
                {
                    result += arrayX[i]();
                }
                return ((result) / (arrayX.Length));
            };
            Console.WriteLine(myAverage(ArrayAnonimMetod));
        }
    }
}
