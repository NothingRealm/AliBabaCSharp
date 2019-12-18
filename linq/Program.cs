using System;
using System.Collections.Generic;
using System.Linq;
namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randInts = { 5, 3, 4, 9, 6, 2, 4, 18, 9, 10 };
            var list = (from n in randInts where n > 10 select n)
            .ToList();
            var sortedList = (from n in randInts orderby n descending select n)
            .ToList();
            Console.WriteLine("sorted descending:");
            var number_of_two = (from n in randInts orderby n descending where n == 2 select n)
            .Count();
            foreach (var item in sortedList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("numbers of two:");
            Console.WriteLine(number_of_two);
            Person person1 = new Person("shayan", "shafaghi", 1, 20);
            Person person2 = new Person("ali", "keshavarz", 2, 19);
            Person person3 = new Person("mohammad", "noor", 1, 21);
            var personList = new List<Person>();
            personList.Add(person1);
            personList.Add(person2);
            personList.Add(person3);
            Scores score1_1 = new Scores(1, 20, "Java");
            Scores score1_2 = new Scores(1, 19, "C#");
            Scores score1_3 = new Scores(1, 18, "C++");
            Scores score2_1 = new Scores(2, 17, "Java");
            Scores score2_2 = new Scores(2, 20, "C#");
            Scores score2_3 = new Scores(2, 18, "C++");
            Scores score3_1 = new Scores(3, 19, "Java");
            Scores score3_2 = new Scores(3, 17, "C#");
            Scores score3_3 = new Scores(3, 15, "C++");
            var scoreList = new List<Scores>();
            scoreList.Add(score1_1);
            scoreList.Add(score1_2);
            scoreList.Add(score1_3);
            scoreList.Add(score2_1);
            scoreList.Add(score2_2);
            scoreList.Add(score2_3);
            scoreList.Add(score3_1);
            scoreList.Add(score3_2);
            scoreList.Add(score3_3);
            var scoreInnerJoinPerson =
                from person in personList
                join score in scoreList on person.id equals score.id
                select person.name + "  got " + score.score + "  on  " + score.course + "\n";
            foreach (var item in scoreInnerJoinPerson)
            {
                Console.WriteLine(item);
            }
            var average =
                (from person in personList
                 join score in scoreList on person.id equals score.id
                 where person.id == 1
                 select score.score).Average();
            Console.WriteLine(average);
        }

        class Person
        {

            public Person(string name, string family, int id, int age)
            {
                this.name = name;
                this.family = family;
                this.id = id;
                this.age = age;
            }

            public string name
            {
                get; set;
            }

            public string family
            {
                get; set;
            }

            public int id
            {
                get; set;
            }
            public int age
            {
                get; set;
            }

        }

        class Scores
        {
            public int id { get; set; }

            public int score { get; set; }

            public string course { get; set; }

            public Scores(int id, int score, string course)
            {
                this.id = id;
                this.score = score;
                this.course = course;
            }

        }

    }
}
