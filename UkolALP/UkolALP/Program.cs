using UkolALP;

Inventory inventar = new Inventory();
string nazevPolozky;
double cenaPolozky;

while (true)
{
    Console.WriteLine("1 - Přidat novou položku");
    Console.WriteLine("2 - Mazat existující položku");
    Console.WriteLine("-----------------------");
    Console.WriteLine("Seznam položek:");
    foreach (var item in inventar.Products)
    {
        Console.WriteLine($"{item.Name} {item.Price}");
    }
    try
    {
        byte vyber = Convert.ToByte(Console.ReadLine());
        switch (vyber)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("Napiš název položky:");
                nazevPolozky = Console.ReadLine();
                Console.WriteLine("Napiš cenu položky:");
                try
                {
                    cenaPolozky = Convert.ToDouble(Console.ReadLine());
                    if (cenaPolozky < 0)
                    {
                        Console.WriteLine("Cena položky nemůže mít zápornou hodnotu!");
                    }
                    else
                    {
                        inventar.AddProduct(nazevPolozky, cenaPolozky);
                    }
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Cena položky musí být číslo!");
                }
                break;
            case 2:
                Console.Clear();
                Console.WriteLine("Napiš název položky, kterou chceš smazat.");
                string nazevPolozkyDelete = Console.ReadLine();
                inventar.RemoveProduct(nazevPolozkyDelete);

                Console.WriteLine("Seznam položek:");
                foreach (var item in inventar.Products)
                {
                    Console.WriteLine($"{item.Name} {item.Price}");
                }

                break;

            default:
                break;
        }
    }
    catch (FormatException)
    {
        Console.Clear();
        Console.WriteLine("Nastala chyba! Musíš zadat číslo!");
    }
}