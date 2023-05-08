using System;

namespace _2
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону Console Application
        //Создайте программу, в которой создайте четыре лямбда оператора для выполнения
        //арифметических действий, первый лямбда оператор для сложения, второй для вычитания,
        //третий для умножения и четвертый для деления(лямбда оператор для деления должен
        //выполнять проверку деления на ноль). Каждый лямбда оператор должен принимать два
        //аргумента и возвращать соответственный результат вычисления.В программе организуйте
        //логику, которая будет выполнять арифметическую операцию указанную пользователем.
        delegate int Operation(int x, int y);
        static void Main(string[] args)
        {
            Console.WriteLine("Каркулятор");
            Console.Write("Введите перове число: ");
            int Number = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int Number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Меню: 1)Сложение 2)Вычитание 3)Умножение 4) Деление");
            Console.Write("Введите цифру указонную возле арефметического действия: ");
            int Function = int.Parse(Console.ReadLine());
            switch (Function)
            {
                case 1:
                    Operation operation1 = (x,y) => x + y;
                    int result = operation1(Number, Number2);
                    Console.WriteLine(result);
                    break;
                case 2:
                    Operation operation2 = (x, y) => x - y;
                    int result2 = operation2(Number, Number2);
                    Console.WriteLine(result2);
                    break;
                case 3:
                    Operation operation3 = (x, y) => x * y;
                    int result3 = operation3(Number, Number2);
                    Console.WriteLine(result3);
                    break;
                case 4:
                    Operation operation4 = (x, y) => x / y;
                    try{
                        int result4 = operation4(Number, Number2);
                        Console.WriteLine(result4);
                    }
                    catch (Exception e){
                        Console.WriteLine(e.Message);
                    }
                    break;
            }
        }
    }
}
