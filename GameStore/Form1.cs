using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GameStore
{
    public partial class Form1 : Form
    {
        // global stream objects
        StreamWriter outputFile;
        StreamReader inputFile;
        // global list object to hold computer game objects
        List<Computer> gameList = new List<Computer>();
        public Form1()
        {
            InitializeComponent();
        }
        public void Help()
        {
            MessageBox.Show("The app allows you to add games to a shopping list, save and load the list.");
        }
    }
}
