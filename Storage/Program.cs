using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    internal class Program
    {
        static void Main(string[] args)
        {
                DataClasses1DataContext db =
               new DataClasses1DataContext();
                var queryResults = from c in db.Product
                                   where c.costPrice > 200
                                   select new
                                   {
                                       ID = c.Id,
                                       Name = c.Name,
                                       Price = c.costPrice
                                   };
                foreach (var item in queryResults)
                {
                    Console.WriteLine(item);
                }
        }
    }
}
