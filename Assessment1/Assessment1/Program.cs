using System;

namespace Assessment1
{
    // Base class
    class Person
    {
        // data members 
        public string name;
        public int age;   
    }
    // inheriting the Person class using :
    class Employee : Person
    {
        // constructor of derived class 
        public Employee()
        {
            Console.WriteLine("Derived Constructor");
        }
        public void readers(string name, int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine("Myself: " + name);
            Console.WriteLine("My age is: " + age);
        }

    }

    // Driver class 
    class Driver
    {
        // Main Method 
        static void Main(string[] args)
        {

            // creating object of derived class 
              Employee g = new Employee();

            // calling the method of base class 
            // using the derived class object 
               g.readers("Jacob", 24);
            Employee e = new Employee();
            // calling the method of derived class 
            e.readers("Rajesh", 25);
        }
    }
}
