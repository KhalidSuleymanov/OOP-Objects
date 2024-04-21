using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask260123
{
    internal class Notebook
    {
        public string Brand;
        public string Model;
        public double Price;

        public Notebook(string Brand, string Model, double Price = 0)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.Price = Price;
        }

        public string ShowInfo()
        {
            return $"Brand: {Brand}, Model: {Model}, Price: {Price}";
        }
    }
}
