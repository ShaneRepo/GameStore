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
        private string _genre;
        private double _price;
        private string _recAge;
        private string _players; // a string b/c 2+ 4+ ect..
        // constructor for the Game class, must include all fields
        public Game(string n, string g, double p, string a,string pl)
        {
            this._name = n;
            this._genre = g;
            this._price = p;
            this._recAge = a;
            this._players = pl;
        }
        // Name property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        // Genre property
        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }
        // Price property
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
        // RecAge property
        public string RecAge
        {
            get { return _recAge; }
            set { _recAge = value; }
        }
        // Players property
        public string Players
        {
            get { return _players; }
            set { _players = value; }
        }
    }
}
