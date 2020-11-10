using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _101120_StructDemo
{
    class Program
    {
        static void Main(string[] args)         //TER INFO Moeder object van alle objecten is object
        {
            #region Old Way
            //string name = "Tom";
            //string adres = "Zondernaam straat";
            //int age = 33;
            //string gender = "M";
            //bool isMarried = false;

            //string name1 = "Jeff";
            //string adres1 = "patatstraat";
            //int age1 = 23;
            //string gender1 = "M";
            //bool isMarried1 = true;

            //string name3 = "Lieze";
            //string adres3 = "Vestenstraat";
            //int age3 = 65;
            //string gender3 = "F";
            //bool isMarried3 = false;

            //Console.WriteLine(name1  +  age3);
            //Console.WriteLine($"Name: {name3}  Age: {age3}");

            #endregion

            #region Init
            Student s1 = new Student();    //INTSTANTIE
            s1.Name = "Jeff";
            //s1.Age = 25;
            s1.IsMarried = true;

            Student s2 = new Student();    //INTSTANTIE
            s2.Name = "Louis";
            s2.Age = 25;
            s2.IsMarried = true;

            Console.WriteLine(s1.Name + s1.Age);     //show    (age zal 0 zijn indien geen waarde)
            //of
            Console.WriteLine($"{s2.Name}");

            Console.WriteLine(s1.Equals(s2));       //maakt een bool en geeft aan of equals true/false

            Student s3 = new Student() { Name = "Jan", Age = 22, IsMarried = true };            // INSTATIE OP ANDERE MANIER ZOALS ARRAY INITIALISEREN
            Console.WriteLine(s3.Name + s3.Age + s3.IsMarried);

            Student s4 = new Student()                                                          //NOG EEN MANIER
            {
                Name = "Tom",
                Age = 20,
                IsMarried = true
            };
            Console.WriteLine(s4.Name + s4.Age + s4.IsMarried);
            #endregion

            #region Constructor   

            Student s5 = new Student();

            #endregion
        }

        public struct Student                 //STRUCT
        {
            //public string Name;        // Hier kan op DEZE manier geen waarde toegevoegd worden
            //public int Age;
            //public bool IsMarried;

            public string name;        // Constructor this.     verwijst naar laatst bewerkte s1,s2,s3,s4.....
            public int age;
            public bool isMarried;


            //Constructor(parameter constructor)
            public Student(string name,int age,bool isMarried)
            {
                this.name = name;
                this.age = age;
                this.isMarried = isMarried;
            }     
        }
    }
}

