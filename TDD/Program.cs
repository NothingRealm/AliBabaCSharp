using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Student student1 = new Student("Shayan", "Shafaghi", 1);
        Lesson lesson1 = new Lesson(3, 18);
        Lesson lesson2 = new Lesson(3, 17);
        Lesson lesson3 = new Lesson(2, 10);
        Lesson lesson4 = new Lesson(4, 20);
    }


    public static int add(int num1, int num2)
    {
        return num1 + num2;
    }

    public static bool isEven(int num)
    {
        return num % 2 == 0;
    }

    public static int Salary(int income, int expense)
    {
        return income - expense;
    }

}