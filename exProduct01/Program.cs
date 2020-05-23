using System;
using System.Globalization;

namespace exProduct01
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Preço: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantity = int.Parse(Console.ReadLine());
            Product prod = new Product(name, price, quantity);
            Console.WriteLine();

            Console.WriteLine($"Dados do produto: {prod}");
            Console.WriteLine();

            Console.Write("Digite o numero de produtos a ser adicionados no estoque: ");
            prod.AddProducts(int.Parse(Console.ReadLine()));
            Console.WriteLine();

            Console.WriteLine($"Dados atualizados: {prod}");
            Console.WriteLine();

            Console.Write("Digite o numero de produtos a ser removidos do estoque: ");
            prod.RemoveProducts(int.Parse(Console.ReadLine()));
            Console.WriteLine();

            Console.WriteLine($"Dados atualizados: {prod}");

        }
    }
}
