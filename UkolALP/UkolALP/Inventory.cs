using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UkolALP
{
    internal class Inventory
    {
        public List<Product> Products = new List<Product>();


        public int count { get; set; }

        public void AddProduct(string name, double price) {
            try
            {
                Product checkNameProduct = Products.Find(x => x.Name == name);
                if (checkNameProduct != null) {
                    Console.WriteLine("Položka už nesmí být v inventáři!");
                }
                else
                {
                    Products.Add(new Product { Name = name, Price = price });
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Nastala neočekávaná chyba! Jsi si jistý, že jsi dosadil do prvního argumentu řetězec znaků a do druhého číslo?");
            }
        }
        public void RemoveProduct(string name) {
            Product smazanyProdukt = Products.Find(x => x.Name == name);
            if (smazanyProdukt != null)
            {
                Products.Remove(smazanyProdukt);
            }
            else
            {
                Console.WriteLine("Tato položka není v inventáři!");
            }
        }
    }
}
