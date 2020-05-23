using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace exProduct01
{
    class Product
    {
        private string _name;
        public double Price { get; private set; }
        public int Quantity { get; private set; }


        public Product(string name, double price, int quantity)
        {
            _name = name;
            Price = price;
            Quantity = quantity;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if(value != null && value.Length > 1)
                {
                    _name = value;
                }
            }
        }


        public double TotalValueInStock()
        {
            return Quantity * Price;
        }

        public void AddProducts(int quantity)
        {
            Quantity += quantity;
        }

        public void RemoveProducts(int quantity)
        {
            Quantity -= quantity;
        }

        public override string ToString()
        {
            return _name + ", $ " + Price.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantity + " unidades, Total: $ " + TotalValueInStock().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
