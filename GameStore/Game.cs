using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
    // base class which all games derive from: TODO make abstract?
    class Game
    {
        private string _name;
        private double _price;
        
        // default constructor
        public Game()
        {

        }
        // constructor for the Game class, must include all fields
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
