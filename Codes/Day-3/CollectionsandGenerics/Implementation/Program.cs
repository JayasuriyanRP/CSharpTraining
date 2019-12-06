using System;
using System.Collections.Generic;
using System.Linq;


namespace Implementation
{
    static class Utility
    {
        static string path;
        public static string Path { set => path = value; get => path; }
        static Utility() { }
        public static void Write(string data)
        {

        }
    }
    class Account
    {
        public Account()
        {

        }
        public Account(string name, int accId)
        {
            AccountName = name;
            AccountId = accId;
        }
        public string AccountName { get; set; }
        public int AccountId { get; set; }
    }
    class Person
    {
        //string name;
        //int age;
        public Person()
        {

        }
        public Person(string name)
        {
            this.Name = name;
        }
        //auto-implemented property
        public string Name { get; set; }
        public int Age { get; private set; }

        public void CalculateAge()
        {
            DateTime dob = new DateTime(12, 5, 1998);
            DateTime current = DateTime.Now;
            TimeSpan ts = current - dob;
            Age = ts.Days / 365;
        }
    }
    class Program
    {
        static void Main()
        {
            //Person anil = new Person("anil");
            //Person sunil = new Person();
            //sunil.Name = "sunil";
            //List<Person> people = new List<Person>();
            //people.Add(anil);
            //people.Add(sunil);

            //object initializer (3.0-2007)
            //Person anil = new Person { Name = "anil " };
            //Person sunil = new Person { Name = "sunil " };

            //collection initializer (3.0-2007)
            //List<Person> people = new List<Person> { anil, sunil };

            List<Person> people = new List<Person>
            {
                new Person{ Name = "anil"},
                new Person{ Name = "sunil"}
            };

            List<Person> filtered = new List<Person>();
            foreach (Person person1 in people)
            {
                if (person1.Name.Contains('a'))
                {
                    filtered.Add(person1);
                }
            }

            //query syntax
            var query = from p in people
                        where p.Name.Contains('a')
                        select p;
            //method syntax
            //expression p=>p.Name.Contains('a'): Lambda expression
            var query1 = people.Where(p => p.Name.Contains('a'));

            //collection initializer (3.0-2007)
            //List<int> list = new List<int> { 1, 1, 2 };
            //HashSet<int> set = new HashSet<int> { 1, 2, 1 };

            //anonymous type
            var joy = new { FirstName = "joydip" };

            List<int> integers = new List<int> { 1, 3, 2, 5, 4, 6, 8, 0, 9, 7 };
            var q = (from num in integers
                     orderby num
                     where num % 2 == 0
                     select num).ToList<int>().Take(3);


        }
    }
}
