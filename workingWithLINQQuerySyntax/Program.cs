using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace thislooksfun
{
    class famousPeople
    {
        public string Name { get; set; }
        public int? BirthYear { get; set; } = null;
        public int? DeathYear { get; set; } = null;
    }

    class Program
    {
        static void Main(string[] args)
        {
            IList<famousPeople> stemPeople = new List<famousPeople>() {
                new famousPeople() { Name= "Michael Faraday", BirthYear=1791,DeathYear=1867 },
                new famousPeople() { Name= "James Clerk Maxwell", BirthYear=1831,DeathYear=1879 },
                new famousPeople() { Name= "Marie Skłodowska Curie", BirthYear=1867,DeathYear=1934 },
                new famousPeople() { Name= "Katherine Johnson", BirthYear=1918,DeathYear=2020 },
                new famousPeople() { Name= "Jane C. Wright", BirthYear=1919,DeathYear=2013 },
                new famousPeople() { Name = "Tu YouYou", BirthYear= 1930 },
                new famousPeople() { Name = "Françoise Barré-Sinoussi", BirthYear=1947 },
                new famousPeople() {Name = "Lydia Villa-Komaroff", BirthYear=1947},
                new famousPeople() {Name = "Mae C. Jemison", BirthYear=1956},
                new famousPeople() {Name = "Stephen Hawking", BirthYear=1942,DeathYear=2018 },
                new famousPeople() {Name = "Tim Berners-Lee", BirthYear=1955 },
                new famousPeople() {Name = "Terence Tao", BirthYear=1975 },
                new famousPeople() {Name = "Florence Nightingale", BirthYear=1820,DeathYear=1910 },
                new famousPeople() {Name = "George Washington Carver", DeathYear=1943 },
                new famousPeople() {Name = "Frances Allen", BirthYear=1932,DeathYear=2020 },
                new famousPeople() {Name = "Bill Gates", BirthYear=1955 }
            };

            // retrieve birthdate after 1900
            Console.WriteLine("[ Birthdate post 1900 ]");
            var result = from b in stemPeople where b.BirthYear >= (1901) select b.Name;
            foreach (var r in result) { Console.WriteLine(r); }
            Console.WriteLine(" [ END OF SECTION ] ");
            // retrieve those with lowercase l in their name
            Console.WriteLine("[ Lowercase 'l' requirement ]");
            var result2 = from l in stemPeople where l.Name.Contains("l") select l.Name;
            foreach (var r in result2) { Console.WriteLine(r); }
            Console.WriteLine(" [ END OF SECTION ] ");
            // count of people who have birthdays after 1900
            Console.WriteLine("[ Birthdays after 1900 ]");
            var result3 = from l in stemPeople where l.BirthYear >= (1901) select l.Name;
            var count = 0;
            foreach (var r in result3) {count++;}
            Console.WriteLine(count);
            Console.WriteLine(" [ END OF SECTION ] ");
            // retrieve people with birthyears between 1920 and 2000 and count
            Console.WriteLine("[ Birthyears between 1920 and 2000 with count ]");
            var result4 = from l in stemPeople where l.BirthYear >= (1920) && l.BirthYear <= (2000) select l.Name;
            var count2 = 0;
            foreach (var r in result4) { Console.WriteLine(r); count2++; }
            Console.WriteLine(count2);
            Console.WriteLine(" [ END OF SECTION ] ");
            // sort list by birthyear
            Console.WriteLine("[ Sort by birthyear ]");
            var result5 = from grenbherginhjb in stemPeople orderby grenbherginhjb.BirthYear select grenbherginhjb.Name;
            foreach (var r in result5) { Console.WriteLine(r); }
            Console.WriteLine(" [ END OF SECTION ] ");
            // retrieve those with deathyear after 1960 and before 2015, then sort
            // cant do multiple query operators at once (error), gonna have to use method syntax :/
            Console.WriteLine("[ Retrieve deathyears between 1960 and 2015 then sort ]");
            var result6 = stemPeople.Where(d => d.DeathYear >= 1961 && d.DeathYear <= 2014).OrderByDescending(d => d.DeathYear).ToList<famousPeople>();
            foreach(var r in result6) { Console.WriteLine(r.Name); }
            Console.WriteLine(" [ END OF SECTION ] ");
        }
    }
}