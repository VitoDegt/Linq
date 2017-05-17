using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Linque
{
    class Actor
    {
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
    }

    abstract class ArtObject
    {

        public string Author { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
    }
    class Film : ArtObject
    {

        public int Length { get; set; }
        public IEnumerable<Actor> Actors { get; set; }
    }
    class Book : ArtObject
    {

        public int Pages { get; set; }
    }
    static class IntExtension
    {
        public static long Factorial (this int val)
        {
           return Enumerable.Range(1, val).Aggregate((f, s) => f * s);
           
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ////string source = @"Hello,World,World,Test,Temp";
            ////foreach (var item in source.Split(',').Where(f => f == "World"))
            ////{
            ////    Console.WriteLine(item);

            ////};
            ////Console.WriteLine(source.Split(',').Count(f => f == "World"));
            ////Console.WriteLine(string.Join(" ",source.Split(',').Select(f => new string(f.Reverse().ToArray()))));

            ////Console.WriteLine(string.Join(",", Enumerable.Range(10,41)));
            ////Console.WriteLine(string.Join(",", Enumerable.Range(10, 41)).Where(f => f%3 ==0).ToArray());
            ////Console.WriteLine(string.Join(" ", Enumerable.Repeat("Linq", 10)));

            //var data = new List<object>() {
            //            "Hello",
            //            new Book() { Author = "Terry Pratchett", Name = "Guards! Guards!", Pages = 810 },
            //            new List<int>() {4, 6, 8, 2},
            //            new string[] {"Hello inside array"},
            //            new Film() { Author = "Martin Scorsese", Name= "The Departed", Actors = new List<Actor>() {
            //                new Actor() { Name = "Jack Nickolson", Birthdate = new DateTime(1937, 4, 22)},
            //                new Actor() { Name = "Leonardo DiCaprio", Birthdate = new DateTime(1974, 11, 11)},
            //                new Actor() { Name = "Matt Damon", Birthdate = new DateTime(1970, 8, 10)}
            //            }},
            //            new Film() { Author = "Gus Van Sant", Name = "Good Will Hunting", Actors = new List<Actor>() {
            //                new Actor() { Name = "Matt Damon", Birthdate = new DateTime(1970, 8, 10)},
            //                new Actor() { Name = "Robin Williams", Birthdate = new DateTime(1951, 8, 11)},
            //            }},
            //            new Book() { Author = "Stephen King", Name="Finders Keepers", Pages = 200},
            //            "Leonardo DiCaprio"
            //        };
            ////foreach (var item in data.Where(f => f is ArtObject == false))
            ////{
            ////    Console.WriteLine(item);

            ////}

            ////foreach (var temp in data.OfType<Film>().SelectMany(f=> f.Actors).Select(f=>f.Name).Distinct().ToArray())
            ////{
            ////    Console.WriteLine(temp);
            ////}

            //Console.WriteLine(10.Factorial());
            //string[] word = new string[] { "hello", "world" };
            //string[] wordsecond = new string[] {"hello", "earth"};
            //string temp = word.Aggregate((wordcom, nextword) => wordcom + " " + nextword);
            //Console.WriteLine(temp);


            List<string> firstList = new List<string>() { "alsdfk", "asdfgs", "testq", "adgdfk", "aabcqw", "aabck" };

            var result = string.Join(" ", firstList.Where(x => x.StartsWith("a")).Where(y => y.EndsWith("k")).Where((z, i) => i % 2 == 0));
            var result2 = string.Join(" ", firstList.Where(x => x.StartsWith("aa")).Select(x => x.Length));
            var result3 = string.Join(" ", firstList.Select(x => $"{x} - {(x.Length)}"));
            var result4 = string.Join(" ", firstList.SelectMany(x => x));
            var result5 = string.Join(" ", firstList.Where(x => x.StartsWith("a")).Take(2));
            var result6 = string.Join(" ", firstList.Where(x => x.Contains("aabc")));

            //Console.WriteLine(result2);

            List<string> secondList = new List<string>() { "al123fk", "asd456fgs", "testq", "ad12gdfk", "aabc23qw", "aabck" };

            var res = string.Join(" ", secondList.Concat(firstList).Skip(1));
            

            Console.WriteLine(res);


        }
    }
}

