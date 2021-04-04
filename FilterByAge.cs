using System;
using System.Collections.Generic;

namespace FilterByAge
{
    static class FilterByAge
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> people = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string[] person = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = person[0];
                int personAge = int.Parse(person[1]);
                people.Add(name, personAge);
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string[] format = Console.ReadLine().Split();
           
            PrintPeopleInfo(people, condition, age, format);

        }
        static void PrintPeopleInfo(Dictionary<string, int> people, string condition, int age, string[] format)
        {
            bool isOlder(int x) => x >= age;
            bool isYounger(int x) => x < age;
            
            if (condition == "older")
            {
                people = people.Filter(isOlder);
            }
            else
            {
                people = people.Filter(isYounger);
            }
            foreach (var person in people)
            {
                string printFormat(string[] x) => x.Length == 2 ? $"{person.Key} - {person.Value}" : x[0] == "name" ? $"{person.Key}" : $"{person.Value}";
                Console.WriteLine(printFormat(format));
            }
        }
        
        static Dictionary<string, int> Filter(this Dictionary<string, int> collection, Func<int, bool> condition)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();

            foreach (var item in collection)
            {
                if (condition(item.Value))
                {
                    result.Add(item.Key, item.Value);
                }
            }
            return result;
        }
    }
}
