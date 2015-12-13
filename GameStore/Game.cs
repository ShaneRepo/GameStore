using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
    // Game class
    class Game : Computer
    {
        private string _name;
        private double _price;
        
        // default constructor
        public Game()
        {

        }
        // constructor for the Game class with params
        public Game(string name, double price)
        {
            _name = name;
            _price = price;
            
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

        public override string ToString()
        {
            return _name + " " + _price;
        }
    }
}
