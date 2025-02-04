using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using static Day_01_G01.ListGenerator;
using static System.Net.Mime.MediaTypeNames;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Partitioning Operators
            #region 1. Get the first 3 orders from customers in Washington
            //var result = CustomerList.Where(c => c.City == "Washington").SelectMany(c=>c.Orders).Take(3);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 2. Get all but the first 2 orders from customers in Washington.
            //var result = CustomerList.Where(c => c.City == "Washington").SelectMany(c => c.Orders).Skip(2);
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.TakeWhile((v, i) => v >= i);
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 4.Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.SkipWhile(p => p % 3 != 0);
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item );
            //}
            #endregion
            #region 5. Get the elements of the array starting from the first element less than its position.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.SkipWhile((v, i) => v >= i);
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion
            #region LINQ - Quantifiers
            #region 1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            //string[] arr = File.ReadAllLines("dictionary_english.txt");
            //var result = arr.Where(a => a.Contains("ei"));
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 2. Return a grouped a list of products only for categories that have at least one product that is out of stock.
            //var result = ProductList
            //    .GroupBy(p => p.Category)
            //    .Where(p => p.Any(i => i.UnitsInStock == 0))
            //    .Select(p => new { cat = p.Key, product = p.ToList() });
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item.cat);
            //    Console.WriteLine("");
            //    foreach(var r in item.product)
            //    {
            //        Console.WriteLine(r);
            //    }
            //    Console.WriteLine("");
            //}
            #endregion
            #region 3. Return a grouped a list of products only for categories that have all of their products in stock.
            //var result = ProductList.GroupBy(c => c.Category)
            //    .Where(c => c.All(i => i.UnitsInStock > 0))
            //    .Select(p => new { cat = p.Key, prods = p.ToList() });
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item.cat);
            //    Console.WriteLine("");
            //    foreach(var prod in item.prods)
            //    {
            //        Console.WriteLine(prod);
            //    }
            //}
            #endregion
            #endregion
            #region LINQ – Grouping Operators
            #region Use group by to partition a list of numbers by their remainder when divided by 5
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var result = numbers.GroupBy(n => n % 5);
            //foreach(var item in result)
            //{
            //    Console.WriteLine($"Numbers with the remainder of {item.Key} when divided by 5:");
            //    foreach(var n in item)
            //    {
            //        Console.WriteLine(n);
            //    }
            //    Console.WriteLine("");

            //}
            #endregion
            #region Uses group by to partition a list of words by their first letter.Use dictionary_english.txt for Input
            //string[] arr = File.ReadAllLines("dictionary_english.txt");
            //var result = arr.GroupBy(n => n.First());
            //foreach(var item in result)
            //{
            //    Console.WriteLine($"the words start with {item.Key}:");
            //    foreach(var n in item)
            //    {
            //        Console.WriteLine(n);
            //    }
            //}
            #endregion
            #region Use Group By with a custom comparer that matches words that are consists of the same Characters Together
            //string[] Arr = { "from", "salt", "earn", "last", "near", "form" };
            //var result = Arr.GroupBy(p => new String(p.Trim().OrderBy(c => c).ToArray()));
            //foreach(var item in result)
            //{
            //    foreach(var wod in item)
            //    {
            //        Console.WriteLine(wod);
            //    }
            //    Console.WriteLine("--------------");
            //}
            #endregion

            #endregion
        }
    }
}
