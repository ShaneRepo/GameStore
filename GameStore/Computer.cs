using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
    class Computer : Game
    {
        // Field
        private string _platform;
        // default constructor
        public Computer()
        {

        }
        // constuctor with params that calls base constuctor
        public Computer(string name, double price)
            : base("name", price)
        {
            
        }
        // Platform property
        public string Platform
        {
            get { return _platform; }
            set { _platform = value; }
        }
    }
}
