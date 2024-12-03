using LabUtils;
using LabUtils.DataModels;

namespace _13_4_WhatItDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("You must specify the number of people to generate");
            }
            else
            {
                int numPeople = Convert.ToInt32(args[0]);
                Person[] people = new Person[numPeople]; 

                for (int i = 0; i < numPeople; i++)
                {
                    people[i] = new Person(Fortuita.NextName(10), 
                               Fortuita.NextName(12),
                               Fortuita.GetRandomInt(100));
                }

                foreach (Person p in people)
                {
                    Console.WriteLine(p);
                }
            }
        }
    }
}
