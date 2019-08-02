using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web.Script.Serialization;

namespace ListsMaleFemale
{
    class Program
    {
        static void Main(string[] args)
        {

            string json = new WebClient().DownloadString("https://uinames.com/api/?ext&amount=25");

            //Console.WriteLine(json);
            List<UI> data = new JavaScriptSerializer().Deserialize<List<UI>>(json);
            List<string> MaleNames = new List<string>();
            List<string> FemaleNames = new List<string>();
            List<int> MaleAges = new List<int>();
            List<int> FemaleAges = new List<int>();

            foreach (UI x in data)
            {
                if (x.gender == "female")
                    FemaleNames.Add($"{x.name} {x.surname}");
                else
                    MaleNames.Add($"{x.name} {x.surname}");
            }
            foreach(UI x in data)
            {
                if (MaleNames.Contains($"{x.name} {x.surname}"))
                {
                    MaleAges.Add(x.age);
                }
            }
            foreach (UI x in data)
            {
                if (FemaleNames.Contains($"{x.name} {x.surname}"))
                {
                    FemaleAges.Add(x.age);
                }
            }

            Console.WriteLine("Would you like to view the UI via M/F, Average/Youngest/Oldest Age.\n E.g:   M   F   Average     Youngest     Oldest\nPlease type your preferance");
            string result = Console.ReadLine();


            if (result == "M")
            {
                Console.WriteLine("Showing only Male names");
                MaleNames.Sort();
                Console.WriteLine();
                Console.WriteLine("\nMale Names: \n");
                foreach (string x in MaleNames)
                {
                    Console.WriteLine(x);
                }

            }

            else if (result == "F")
            {
                Console.WriteLine("Showing only Female names");
                FemaleNames.Sort();
                Console.WriteLine();
                Console.WriteLine("\nFemale Names: \n");
                foreach (string x in FemaleNames)
                {
                    Console.WriteLine(x);
                }

            }
            else if (result == "Average")
            {
                Console.WriteLine($"Average Male Age {MaleAges.Sum()/MaleAges.Count}");
            }
            else if (result == "Youngest")
            {
                Console.WriteLine($"Youngest Male Age {MaleAges[0]}");
            }
            else if (result == "Oldest")
            {
                Console.WriteLine($"The Oldest Age {MaleAges[MaleAges.Count-1]}");
            }
            else Console.WriteLine("ERROR ERROR PLEASE REOPEN THE PROGRAM"); Environment.Exit(0);


            
            /*

                FemaleNames.Sort();
                Console.WriteLine();
                Console.WriteLine("\nFemale Names: \n");
                foreach (string x in FemaleNames)
                {
                    Console.WriteLine(x);
                }

                MaleNames.Sort();
                Console.WriteLine();
                Console.WriteLine("\nMale Names: \n");
                foreach (string x in MaleNames)
                {
                    Console.WriteLine(x);
                }
                */


        }
    }
   class UI
    {
        public string gender { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
    }
}
