using IndexerException.Models;
using IndexerException.Utilies;
using System;
using System.Reflection;

namespace IndexerException
{
    class Program
    {
        static void Main(string[] args)
        {
            #region operator overloading
            //Person p1 = new Person(19, "Ibrahim");
            //Person p2 = new Person(21, "Gunay");
            //Person p3 = new Person(20, "Gulchin");
            //Person[] people = { p2, p1,p3 };
            //Array.Sort(people);
            //foreach (var item in people)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Indexer
            //Library libraff = new Library("Libraff", 1000);
            //libraff[0] = new Book("Xemse");
            //Console.WriteLine(libraff[2]);
            #endregion

            #region Exception
            //try
            //{
            //    Library libraff = new Library("Libraff", 100);
            //    Console.WriteLine(libraff[101]);
            //}
            //catch (OutOfCapasityException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //try
            //{
            //    int n1 = int.Parse(Console.ReadLine());
            //    int n2 = int.Parse(Console.ReadLine());
            //    Console.WriteLine(n1/n2);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion

            #region Reflection
            Assembly executing = Assembly.GetExecutingAssembly();

            // Array to store types of the assembly
            Type[] types = executing.GetTypes();
            foreach (var item in types)
            {
                // Display each type
                Console.WriteLine("Class : {0}", item.Name);

                // Array to store methods
                MethodInfo[] methods = item.GetMethods();
                foreach (var method in methods)
                {
                    // Display each method
                    Console.WriteLine("--> Method : {0}", method.Name);

                    // Array to store parameters
                    ParameterInfo[] parameters = method.GetParameters();
                    foreach (var arg in parameters)
                    {
                        // Display each parameter
                        Console.WriteLine("----> Parameter : {0} Type : {1}",
                                                arg.Name, arg.ParameterType);
                    }
                }
            }
            #endregion
        }
    }

    #region operator overloading
    class Person:IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(int age,string name)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return Name;
        }

        public int CompareTo(object obj)
        {
            return Age.CompareTo(((Person)obj).Age);
        }

        public static  int operator -(Person p1,Person p2)
        {
            return p1.Age - p2.Age;
        }

        public static int operator +(Person p1, Person p2)
        {
            return p1.Age + p2.Age;
        }

        public static bool operator >(Person p1,Person p2)
        {
            return p1.Age > p2.Age;
        }

        public static bool operator <(Person p1, Person p2)
        {
            return p1.Age < p2.Age;
        }

        public static bool operator ==(Person p1, Person p2)
        {
            return p1.Age == p2.Age;
        }

        public static bool operator !=(Person p1, Person p2)
        {
            return p1.Age != p2.Age;
        }
    }
    #endregion
}
