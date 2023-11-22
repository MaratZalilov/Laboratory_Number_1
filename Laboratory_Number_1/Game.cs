using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory_Number_1
{
    
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        private void MainButton_Click(object sender, EventArgs e)
        {
            Controls.Remove(MainButton);
            SecondaryButton();
            MessageBox.Show("''''''''''''''''''''''''");
        }
        public void SecondaryButton()
        {

            int W = 330, H = 200;
            MyButton[] button = new MyButton[3];

            for (int j = 0; j < 3; j++)
            {

                button[j] = new MyButton(j, j.ToString());
                button[j].BackColor = Color.DarkGray;
                button[j].Name = "Buttons";
                button[j].Size = new Size(200, 50);
                button[j].Location = new Point(W, H += 50);
                button[j].Click += new System.EventHandler(button[j].Poluchit);

                button[j].Tag = new Point(j);
                Controls.Add(button[j]);
                //H = H + 100;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    public class MyButton : Button
    {
        private int number;
        public MyButton(int i, string name)
        {
            number = i;
            this.Text = name;
        }

        public void Poluchit(object sender, EventArgs e)
        {
            MessageBox.Show(number.ToString());
        }
    }
}
