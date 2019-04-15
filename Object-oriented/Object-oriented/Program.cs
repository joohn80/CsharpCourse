<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented
{
    class Program
    {
        static void Main(string[] args)
        {
            Person John = new Person("John", "Blom", 21);
            John.speak();

            Console.WriteLine(John);

            Console.WriteLine($"instance { Person.GetInstanceCount() }");

            Console.ReadKey();
        }

        
    }

    class Person
    {
        public string firstname;
        public string lastname;
        public int age;
        private static int InstanceCount = 0;

        private static int IncreaseInstanceCount()
        {
            return InstanceCount++;
        }
        public static int GetInstanceCount()
        {
            return InstanceCount;
        }

        public override string ToString()
        {
            return $"{firstname}, {lastname}, {age}";
        }

        public Person(string firstname, string lastname, int age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
            IncreaseInstanceCount();
        }

        public void speak()
        {
            Console.WriteLine($"Hello my name is {firstname} {lastname}");
        }

        class Employee: Person
        {
            public double Salary = 10000;
            

            public Employee(double salary)
            {
                Salary = salary;
            }
        }

        public

        class Client: Person
        {

        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented
{
    class Program
    {
        static void Main(string[] args)
        {
            Person John = new Person("John", "Blom", 21);
            John.speak();

            Console.WriteLine(John);

            Console.WriteLine($"instance { Person.GetInstanceCount() }");

            Console.ReadKey();
        }

        
    }

    class Person
    {
        public string firstname;
        public string lastname;
        public int age;
        private static int InstanceCount = 0;

        private static int IncreaseInstanceCount()
        {
            return InstanceCount++;
        }
        public static int GetInstanceCount()
        {
            return InstanceCount;
        }

        public override string ToString()
        {
            return $"{firstname}, {lastname}, {age}";
        }

        public Person(string firstname, string lastname, int age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
            IncreaseInstanceCount();
        }

        public void speak()
        {
            Console.WriteLine($"Hello my name is {firstname} {lastname}");
        }

        class Employee: Person
        {
            public double Salary = 10000;
            

            public Employee(double salary)
            {
                Salary = salary;
            }
        }

        public

        class Client: Person
        {

        }
    }
}
>>>>>>> 1de7265acb7f4f9c4dfaa0a44be2721b96d31c35
