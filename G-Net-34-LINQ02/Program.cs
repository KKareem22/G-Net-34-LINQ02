using G_Net_34_LINQ02.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using static G_Net_34_LINQ02.DataSources.Source;
namespace G_Net_34_LINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            ////Get top 3 most expensive products
            //var query = ProductList
            //    .OrderByDescending(p => p.UnitPrice)
            //    .Take(3);
            //Helper.PrintWithNewLine("Top 3 Product For Price", query);
            #endregion
            #region Q02
            //show page 2 of products, with page size = 5
            //var query=ProductList
            //    .Skip(5).Take(5);
            //Helper.PrintWithNewLine("6 to 10 Products", query);
            #endregion
            #region Q03
            //Take products from the list as long as Their UnitPrice is less than $25(list is ordered by price).
            //var query = ProductList
            //    .Where(p => p.UnitPrice < 25)
            //    .OrderByDescending(p => p.UnitPrice);
            //Helper.PrintWithNewLine("List of Product Price Less 25 $", query);

            #endregion
            #region Q04
            //Check if ALL products in the "Seafood" category are in stock

            //var query = ProductList
            //    .Where(p => p.Category == "Seafood")
            //    .All(p => p.UnitsInStock > 0);
            //Console.WriteLine($"All Products in the 'Seafood' are in stock ? : {query}");

            #endregion
            #region Q05
            //Check if the ID list contains 9

            //int[] ids = { 3, 9, 13, 18 };
            //var query = ids.Contains(9);
            //Console.WriteLine($"Ids contains 9 ?: {query}");
            #endregion
            #region Q06
            //Group all products by Category and print each group with its product count.

            //var query = ProductList
            //    .GroupBy(p => p.Category);
            //Helper.PrintWithGrouping("Group products by Category", "Category", query);
            #endregion
            #region Q07
            //Group products by Category and project only product names per group

            //var query = ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        Count=g.Count(),
            //        ProductName = string.Join(", \n", g.Select(p => p.ProductName))
            //    });
            //foreach (var item in query)
            //{ 
            //    Console.WriteLine($"Category : {item.Category}");
            //    Console.WriteLine($"Count : {item.Count}");
            //    Console.WriteLine($"Product Names : \n{item.ProductName}");
            //    Console.WriteLine(new string('-', 30));
            //}

            #endregion
            #region Q08
            //Find all categories that have MORE THAN 3 products
            //var query = ProductList
            //    .GroupBy(p => p.Category)
            //    .Where(g => g.Count() > 3);
            //Helper.PrintWithGrouping("Categories with more than 3 products", "Category", query);

            #endregion
            #region Q09
            //Using QUERY SYNTAX, group customers by Country, and for each
            //group select { Country, Count, TotalOrderValue }.


            //var query = from c in CustomerList
            //            group c by c.Country
            //          into g
            //            select new
            //            {
            //                Country = g.Key,
            //                Count = g.Count(),
            //                TotalOrderValue = g.Sum(c => c.Orders.Sum(o => o.Total))
            //            };
            //Helper.PrintWithNewLine("Group customers by Country", query);

            #endregion
            #region Q10
            //Calculate the total number of units in stock across all products

            //var Total = ProductList.Sum(p => p.UnitsInStock);
            //Console.WriteLine($"Total = {Total}");
            #endregion
            #region Q11
            //Find the CHEAPEST and MOST EXPENSIVE product prices

            //var MaxPrice = ProductList.Max(p => p.UnitPrice);
            //var MinPrice = ProductList.Min(p => p.UnitPrice);
            //Console.WriteLine($"Expensive Price = {MaxPrice}");
            //Console.WriteLine($"Cheapest Price = {MinPrice}");
            #endregion
            #region Q12
            //Get a distinct list of all product categories

            //var query = ProductList
            //    .Select(p => p.Category)
            //    .Distinct();
            //Helper.PrintWithNewLine("Distinct list of all product categories", query);
            #endregion
            #region Q13
            //find product IDs that are in setA but NOT in setB
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };
            //Helper.PrintList("Set A", setA);
            //Helper.PrintList("Set B", setB);
            //var query = setA.Except(setB);
            //Helper.PrintList("Product IDs that are in setA but NOT in setB", query);

            #endregion
            #region Q14
            //Find countries that appear in list1 but NOT in list2
            // (case -insensitive).
            //    string[] list1 = { "Germany", "France", "UK", "Spain" };
            //    string[] list2 = { "france", "SPAIN", "Italy" };

            //var query=list1.Except(list2,StringComparer.OrdinalIgnoreCase);
            //Helper.PrintList("List1 Except List2 ", query);
            #endregion
            #region Q15
            //Build a Dictionary<int, Product> keyed by ProductID. Then
            //retrieve and print the product with ID = 18.

            //var query = ProductList
            //    .ToDictionary(p => p.ProductID);
            //Console.WriteLine(query[18]);
            #endregion
            #region Q16
            //Get the first product whose price is greater than $50.

            //var query = ProductList.First(p => p.UnitPrice > 50);
            //Console.WriteLine(query);
            #endregion
            #region Q17
            //Try to get the first product with a price > $500. it returns null
            //instead of throwing.

            //var query = ProductList.FirstOrDefault(p => p.UnitPrice > 500);
            //Console.WriteLine(query);
            #endregion
            #region Q18
            //Generate a multiplication table row for 7
            //var query = Enumerable.Range(1, 12).Select(n => n * 7);
            //Helper.PrintList("multiplication", query);
            #endregion

        }
    }
}
