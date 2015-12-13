using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
    abstract class Computer // abstract class 
    {
        // Fields
        private string _name;
        private double _price;
        // default constructor
        public Computer()
        {

        }
        // constuctor with params 
        public Computer(string name, double price)
        {
            
        }
        // Name property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        // Price property
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
