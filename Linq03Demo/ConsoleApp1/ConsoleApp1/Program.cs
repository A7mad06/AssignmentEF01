using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using static Day_01_G01.ListGenerator;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Quantifier Operators
            #region Any
            //Console.WriteLine(ProductList.Any(p=>p.UnitsInStock==0));
            #endregion
            #region All

            #endregion
            #region Contains

            #endregion
            #region sequence
            //var seq1 = Enumerable.Range(0, 100);
            //var seq2 = Enumerable.Range(0, 100);
            //Console.WriteLine(seq1.SequenceEqual(seq2));
            #endregion
            #endregion
            #region Transformation Operators
            //List<string> Words = new List<string>() { "Ten", "Twenty", "Thirty", "Fourty" };
            //int[] Numbers = { 10, 20, 30, 40 };
            //var result = Numbers.Zip(Words);
            //var result2 = Numbers.Zip(Words,(number,word)=>$"{number}={word}");
            //var result3 = Numbers.Zip(Words, [1, 2, 3]);
            //foreach(var item in result3)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Grouping Operators
            #region Exapmle01
            //var result = from P in ProductList
            //             group P by P.Category;
            //var result = ProductList.GroupBy(p => p.Category);
            //foreach(var group in result)
            //{
            //    Console.WriteLine(group.Key);
            //    Console.WriteLine(group.Count());
            //    foreach(var item in group)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            #endregion
            #region Example02
            //var result = from P in ProductList
            //             where P.UnitsInStock > 0
            //             group P by P.Category
            //             into Groups
            //             where Groups.Count() < 10
            //             select new { Category = Groups.Key, Count = Groups.Count() };
            //var result = 
            //foreach(var item in result)
            //{
            //    Console.WriteLine($"{item.Category}::{item.Count}");
            //}
            #endregion
            #endregion
            #region Partition Operators
            //var result = ProductList.Where(p => p.UnitsInStock > 0).Take(5);
            //var result2 = ProductList.Where(p => p.UnitsInStock > 0).TakeLast(5);
            //var result3 = ProductList.Where(p => p.UnitsInStock > 0).SkipLast(5);
            //var result4 = ProductList.Where(p => p.UnitsInStock > 0).Skip(5);
            //int[] Numbers = { 3, 2, 3 };
            //var result5 = Numbers.SkipWhile(number => number % 3 == 0);
            //foreach(var item in result5)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Let & Into
            //List<string> Names = new List<string>() { "Rana", "Ahmed", "Omar" };
            //var result = from n in Names
            //             select Regex.Replace(n, "[aeiouAIEOU]", string.Empty)
            //             into New
            //             where New.Length > 2
            //             select New;
            //var result = from n in Names
            //            let N = Regex.Replace(n, "[aeiouAIEOU]", string.Empty)
            //            where N.Length>2
            //            select N;
            //var result = Names.Select(N => Regex.Replace(N, "[aeiouAIEOU]", string.Empty)).Where(N=>N.Length>2);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
        }
    }
}
