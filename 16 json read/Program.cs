using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace _16_json_read
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonstring = String.Empty;
         using (StreamReader sr=new StreamReader("../../../Products.json"))
            {
                jsonstring = sr.ReadToEnd();
            }
            Product[] products = JsonSerializer.Deserialize<Product[]>(jsonstring);
            Product maxProduct = products[0];
            foreach(Product p in products)
            {
                if (p.Price>maxProduct.Price)
                {
                    maxProduct = p;
                }
            }
            Console.WriteLine($"{maxProduct.Code} {maxProduct.Name} {maxProduct.Price}");
            Console.ReadKey();
        }
    }
}
