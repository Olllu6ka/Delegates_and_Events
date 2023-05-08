using System;

namespace Delegates_and_Events
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону Console Application
        //Создайте программу в которой создайте класс делегат, который в качестве параметров
        //принимает три целочисленных аргумента и возвращает целочисленный тип.Далее создайте
        //анонимный метод, который также принимает три целочисленных аргумента и возвращает
        //среднее арифметическое этих аргументов. Сообщите данный анонимный метод с экземпляром
        //делегата, который был ранее создан.
        public delegate void MyAnonimdelegate();
        public delegate int MyDelegate(int a, int b, int c);
        static void Main(string[] args)
        {
            Console.Write("Введите перове число:");
            int Number1 = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число:");
            int Number2 = int.Parse(Console.ReadLine());
            Console.Write("Введите третие число:");
            int Number3 = int.Parse(Console.ReadLine());
            MyAnonimdelegate myAnonimdelegate = delegate {
                int result = (Number1 + Number2 + Number3) / 3;
                Console.WriteLine("Возвращание целочисленного типа с помощью анонимного делегата - " + result);
            };
            myAnonimdelegate();
            MyDelegate myDelegate = new MyDelegate(MyClass.Average);
            myDelegate.Invoke(Number1, Number2, Number3);
        }
        static class MyClass {
            public static int Average(int a, int b,int c){
                int result = a + b + c;
                Console.Write("Возвращание целочисленного типа с помощью делегата - " + result);
                return result;
            }
        }

    }
}
