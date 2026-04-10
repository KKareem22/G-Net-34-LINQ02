using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_LINQ02
{
    public class Helper
    {
        public static void PrintWithNewLine<T>(string Name, IEnumerable<T> collection)
        {
            Console.WriteLine(new string('_', 30));
            Console.WriteLine($"{Name}");
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('_', 30));
        }
        public static void PrintList<T>(string Name, IEnumerable<T> collection)
        {
            Console.WriteLine(new string('_', 30));
            Console.WriteLine($"{Name} :[{string.Join(',', collection)}]");
            Console.WriteLine(new string('_', 30));
        }
        public static void PrintWithGrouping<TKey, TValue>(string Name, string GroupWith, IEnumerable<IGrouping<TKey, TValue>> collection)
        {
            Console.WriteLine(new string('_', 50));
            Console.WriteLine($"{Name}");
            foreach (var item in collection)
            {
                Console.WriteLine($"{GroupWith} : {item.Key}");
                Console.WriteLine($"Count : {item.Count()}");
                foreach (var subItem in item)
                {
                    Console.WriteLine(":" + subItem);
                }
                Console.WriteLine();
            }
            Console.WriteLine(new string('_', 50));
        }
    }
}
