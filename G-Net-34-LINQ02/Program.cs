using G_Net_34_LINQ02.Models;
using System.Collections.Generic;
using System.Diagnostics;
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

        }
    }
}
