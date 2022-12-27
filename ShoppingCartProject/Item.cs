using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartProject
{
    public class Item
    {
        public int id;
        private string description;
        private int _quantity;
        public double price;

        //public Item()
        //{
        //    _quantity = 1;
        //    Console.WriteLine("Object created");
        //}

        public Item(int _quantity)
        {
            this._quantity = _quantity;
            Console.WriteLine("Launching the browser");
        }

        //public Item(int _quantity, string description)
        //{
        //    this._quantity = _quantity;
        //    this.description = description;
        //}

        //public Item(string description, int _quantity)
        //{
        //    this._quantity = _quantity;
        //    this.description = description;
        //}
        //public Item(double price)
        //{

        //}

        public string Description
        {
            get { return description; }
            set { description = value; }
        }


        public int Quantity
        {
            set
            {
                if (value > 0)
                {

                    _quantity = value;
                }
                else
                {
                    Console.WriteLine("Qty cannot be negative!!");
                }
            }
        }

        public void DisplayItemDetail()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine(id);
            Console.WriteLine(description);
            Console.WriteLine(_quantity);
            Console.WriteLine(price);
            Console.WriteLine("-------------------");
        }


        public static Item CreateInstance(int quantity)
        {
            Item i = new Item(quantity);

            return i;
        }

        public static void PrintDescription(Item i)
        {
            Console.WriteLine(i.Description);
        }



        public void PrintDiscountedPrice()
        {
            //int price = 0;
            if (_quantity == 2)
            {
                Console.WriteLine((this.price - (price * 10 / 100.0)) * _quantity);
            }
            else if (_quantity >= 3 && _quantity <= 5)
            {
                Console.WriteLine((price - (price * 15 / 100.0)) * _quantity);
            }
            else if (_quantity > 5)
            {
                Console.WriteLine((price - (price * 25 / 100.0)) * _quantity);
            }
            else
            {
                Console.WriteLine("No discount");
            }
            Console.WriteLine("-------------------");
        }
    }
}
