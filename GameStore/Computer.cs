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
        public Computer(string plat,string name,string genre, double price, string recAge, string players)
            : base("name", "genre", price, "recAge", "players")
        {
            _platform = plat;
        }
        // Platform property
        public string Platform
        {
            get { return _platform; }
            set { _platform = value; }
        }
    }
}
