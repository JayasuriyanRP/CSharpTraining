using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo_Remaining
{
    abstract class Person
    {
        protected string name;
        public Person()
        {

        }
        public Person(string name)
        {
            this.name = name;
        }
        public string Name { get => name; set => name = value; }
        public virtual string Print()
        {
            return $"Name: {name}";
        }
        public abstract bool IsOutstanding();
    }
    class Student : Person
    {
        double marks;
        public Student()
        {

        }
        public Student(string name, double marks) : base(name)
        {
            this.marks = marks;
        }
        public double Marks { get => marks; set => marks = value; }
        public override string Print()
        {
            return $"{base.Print()} and Marks:{marks}";
        }
        public override bool IsOutstanding()
        {
            return this.marks > 85 ? true : false;
        }
    }
    class Professor : Person
    {
        int booksPublished;
        public Professor()
        {

        }
        public Professor(string name, int books) : base(name)
        {
            this.booksPublished = books;
        }
        public override string Print()
        {
            return $"{base.Print()} and Books:{booksPublished}";
        }
        public override bool IsOutstanding()
        {
            return this.booksPublished > 4 ? true : false;
        }
    }
    class Program
    {
        static void Main()
        {
            Person student = new Student("joy", 45);
            Console.WriteLine(student.Print());
        }
    }
}
