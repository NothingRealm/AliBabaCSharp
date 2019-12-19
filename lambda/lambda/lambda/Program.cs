using System;
using System.Linq;

namespace lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {14, 1, 9, 8, 31, 12, 5, 6, 16, 7, 3, 3, 3, 3};
            string[] names = {"shayan", "hadi", "rahim", "mohammad", "taghad"};
            var check = numbers.Where(a => a == 2).Any();
            var checkWithAny = numbers.Any(a => a == 2);
            var firsstSelect = numbers.Where(a => a == 3).First();
            var secondSelect = numbers.Where(a => a == 13).FirstOrDefault();
            var thirdSelect = numbers.Where(a => a == 14).Single();
            var fourthSelect = numbers.Where(a => a == 1).SingleOrDefault();
            var nameSelect = names.Where(name => name.ToLower().Contains('i'));
            var nameSelectStart = names.Where(name => name.ToLower()[0] == 's');
            var nameSelectEnd = names.Where(name => name.ToLower()[name.Length - 1] == 'm');
            // names containing i
            foreach (var name in nameSelect)
            {
                Console.WriteLine(name);
            }

            // names started with s
            foreach (var name in nameSelectStart)
            {
                Console.WriteLine(name);
            }

            // names ende with m
            foreach (var name in nameSelectEnd)
            {
                Console.WriteLine(name);
            }

            Person person1 = new Person(0, "shayan", "shafaghi");
            Person person2 = new Person(1, "hadi", "taba");
            Person person3 = new Person(2, "dennis", "ritchie");

            Income income1 = new Income(0, 100, 500, 600);
            Income income2 = new Income(1, 50, 600, 500);
            Income income3 = new Income(2, 400, 700, 600);

            var salaries = new Salary[]
            {
                new Salary(0, 100, "day"),
                new Salary(0, 500, "bahman"),
                new Salary(0, 600, "esfand"),
                new Salary(1, 50, "day"),
                new Salary(1, 600, "bahman"),
                new Salary(1, 500, "esfand"),
                new Salary(2, 400, "day"),
                new Salary(2, 700, "bahman"),
                new Salary(2, 600, "esfand"),
            };

            var persons = new Person[] {person1, person2, person3};
            var incomes = new Income[] {income1, income2, income3};

            var max = persons.Join(incomes, person => person.id, income => income.id,
                    (person, income) => new
                        {id = person.id, sum = income.incomeBahman + income.incomeDay + income.incomeEsfand})
                .Max(per => per.sum);
            Console.WriteLine(max);

            var max2 = persons.GroupJoin(salaries,
                person => person.id, salary => salary.id, (person, salaries) => new
                {
                    name = person.name,
                    sum = salaries.ToArray().Sum(s => s.salary)
                });

            var greatestSal = max2.Where(x => x.sum == max2.Max(x => x.sum));
            foreach (var person in greatestSal)
            {
                Console.WriteLine(person.name + " has the max salary with " + person.sum);
            }
        }
    }

    class Person
    {
        public Person(int id, string name, string lastName)
        {
            this.id = id;
            this.name = name;
            this.lastName = lastName;
        }

        public int id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
    }

    class Income
    {
        public Income(int id, int incomeDay, int incomeBahman, int incomeEsfand)
        {
            this.id = id;
            this.incomeDay = incomeDay;
            this.incomeBahman = incomeBahman;
            this.incomeEsfand = incomeEsfand;
        }

        public int id { get; set; }
        public int incomeDay { get; set; }
        public int incomeBahman { get; set; }
        public int incomeEsfand { get; set; }
    }

    class Salary
    {
        public int id { get; set; }
        public int salary { get; set; }
        public string month { get; set; }

        public Salary(int id, int salary, string month)
        {
            this.id = id;
            this.salary = salary;
            this.month = month;
        }
    }
}