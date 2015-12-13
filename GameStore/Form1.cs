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
        // global list object to hold game objects
        List<Game> gameList = new List<Game>();
        Game someGame;
        public Form1()
        {
            InitializeComponent();
        }
        public void Help()
        {
            MessageBox.Show("The app allows you to add games to a shopping list, save and load the list.");
        }
        // method to convert listbox items to list
        //public void ToList()
        //{          
        //     foreach (string g in listBoxGames.Items)
        //     {

        //         Game j = new Game(g.Name,g.Price);
        //         gameList.Add(j);
        //     }         
        //}

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //ToList();
            try
            {
                StreamWriter outputFile = File.CreateText("list.txt");
                foreach (Game g in gameList)
                {
                    outputFile.WriteLine(g);
                }
                outputFile.Close();
                MessageBox.Show("Your file has been saved.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No data to save. Enter games into the list first.");
            }
        }
        // call the help method
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            Help();
        }
        // clear the listbox
        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxGames.Items.Clear();
        }
        // load the listbox
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputFile = File.OpenText("list.txt");
                while (!inputFile.EndOfStream)
                {
                    List<string> gameList2 = new List<string>();
                    //listBoxGames.Items.Add(inputFile.ReadLine());
                    gameList2.Add(inputFile.ReadLine());
                    foreach (string g in gameList2)
                    {
                        //string output;
                        //output = g.Name + " " + g.Price;
                        listBoxGames.Items.Add(g);
                    }
                    
                }
                inputFile.Close();
                MessageBox.Show("Your file has been loaded into the listbox.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No file to load. Save a file first then try loading.");
            }
        }
        // add a game to the listbox
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                Game someGame = new Game();
                string output;
                someGame.Name = textBoxName.Text;
                someGame.Price = double.Parse(textBoxPrice.Text);
                gameList.Add(someGame);
                foreach (Game g in gameList)
                {
                    output = g.Name + " " + g.Price;
                    listBoxGames.Items.Add(output);
                }
                //listBoxGames.Items.Add(gameList);
                //listBoxGames.Items.Add(someGame.Price).ToString();
                textBoxName.Clear();
                textBoxPrice.Clear();
                textBoxName.Focus();
            }
            else
            {
                MessageBox.Show("Enter a game into the textbox you want to add.");
                textBoxName.Focus();
            }
        }
    }
}
