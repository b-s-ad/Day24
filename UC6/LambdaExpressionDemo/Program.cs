using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace LambdaExpressionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listPersonInCity = new List<Person>();
            AddRecords(listPersonInCity);

            Retrieving_TopTwoRecord_ForAgels_LessThanSixty(listPersonInCity);//uc2
            WriteLine("----------------------------------------------");
            //CheckingForTeenagerPerson(listPersonInCity);//uc3
            //AllPersonsAverageAge(listPersonInCity);//uc4
            //CheckNameExistOrNot(listPersonInCity);//uc5
            SkipRecordLessThanSixtyAge(listPersonInCity);//uc6
            Console.ReadKey();
        }

        // UC1
        private static void AddRecords(List<Person> listPersonInCity)
        {
            listPersonInCity.Add(new Person("203456876", "John", "12 Main Street, Newyork,NY", 15));//uc3
            //listPersonInCity.Add(new Person("203456876", "John", "12 Main Street, Newyork,NY", 19));//uc3
            listPersonInCity.Add(new Person("203456877", "SAM", "13 Main Ct, Newyork,NY", 25));
            listPersonInCity.Add(new Person("203456878", "Elan", "14 Main Street, Newyork,NY", 35));
            listPersonInCity.Add(new Person("203456879", "Smith", "12 Main Street, Newyork,NY", 45));
            listPersonInCity.Add(new Person("203456880", "SAM", "345 Main Ave, Dayton,OH", 55));
            listPersonInCity.Add(new Person("203456881", "Sue", "32 Cranbrook Rd, Newyork,NY", 65));
            listPersonInCity.Add(new Person("203456882", "Winston", "1208 Alex st, Newyork,NY", 65));
            listPersonInCity.Add(new Person("203456883", "Mac", "126 Province Ave, Baltimore,NY", 85));
            listPersonInCity.Add(new Person("203456884", "SAM", "126 Province Ave, Baltimore,NY", 95));
            // Console.WriteLine(listPersonInCity.ToString());
            // listPersonInCity.ForEach(x => Console.WriteLine("{0}\t",x.Name.ToString()));

        }


        // UC2
        private static void Retrieving_TopTwoRecord_ForAgels_LessThanSixty(List<Person> listPersonsInCity)
        {
            //foreach (Person person in listPersonsInCity.FindAll(e => (e.Age < 60)).Take(2).ToList())
                 foreach (Person person in listPersonsInCity.FindAll(e => (e.Age < 96)).ToList())
                {
                Console.WriteLine("\nName : " + person.Name + "\t\tAge : " + person.Age);
                
            }

        }


        //UC3
        private static void CheckingForTeenagerPerson(List<Person> listPersonsInCity)
        {
            if (listPersonsInCity.Any(e => e.Age >= 13 && e.Age < 19))
            {
                Console.WriteLine("\nYes, we have some teen-agers in the list");
            }
            else
                Console.WriteLine("\nNo, we don't have teen-agers in the list");

        }

        //UC4
        private static void AllPersonsAverageAge(List<Person> listPersonInCity)
        
        {

            double avgAge = listPersonInCity.Average(e => e.Age);
            Console.WriteLine("\nThe average of all the person's age is : " + avgAge);
        }

        // UC5
        private static void CheckNameExistOrNot(List<Person> listPersonsInCity)
        {
            if (listPersonsInCity.Exists(e => e.Name == "SAM"))
            {
                Console.WriteLine("\nYes, A person having name  '|SAM|' exists in our list");
            }
        }

        // UC6
        private static void SkipRecordLessThanSixtyAge(List<Person> listPersonsInCity)
        {
            foreach (Person person in listPersonsInCity.SkipWhile(e => e.Age < 60))
            {
                
                Console.WriteLine("Name : " + person.Name + " \t\tAge: " + person.Age);
            }
        }

    }
}

