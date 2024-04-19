using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    public class Product
    {
        public int _code;
        private string _name;
        private string _description;
        private double _price;
        private double _iva;
        
        public Product(string name, string description, double price, double iva)
        {
            _code = GenerateCode();
            _name = name;
            _description = description;
            _price = price;
            _iva = iva;

        }

        public int Code
        {
            get { return _code; }

            private set { _code = value; }
        }

        public string Name
        {
            get { return _name; }

            set { _name = value; }
        }

        public string Description 
        {
            get { return _description; }

            set { _description = value; }
        }

        public double Price
        {
            get { return _price; }

            set { _price = value; }

        }

        public double Iva 
        {
            get { return _iva;  }

            set { _iva = value; }
        }
        
        private int GenerateCode()
        {
            Random rand = new Random();

            return rand.Next(100000000);
        }



        
    }
}
