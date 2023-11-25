using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text;
namespace Laboratory_Number_1
{

    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }
        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }
        Point lastPoint;

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }
        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void MainButton_Click(object sender, EventArgs e)
        {

            SecondaryButton();
            MainText.Text = "Вы являетесь гомосексуалистом?";
            MainPanel.Controls.Remove(MainButton);

        }
        private void Buttons_Click(object sender, EventArgs e)
        {
            
            MyButton b = (MyButton)sender;
            int i = b.GetNum();
            MessageBox.Show(i.ToString());
           
           // MyButton.MethodSelection();

        }
        
        public void SecondaryButton()
        {

            int W = 330, H = 200;
            MyButton[] button = new MyButton[3];
            List<string> buttons = new List<string>();
            for (int j = 0; j < 3; j++)
            {
               
                 
                button[j] = new MyButton(j, MyButton.GiveAnAnswer(),buttons);
                button[j].BackColor = Color.Orange;
                button[j].Name = $"Buttons"+$"{j}";
             //   buttons.Add(buttons[j]);
                button[j].Size = new Size(200, 50);
                button[j].Location = new Point(W, H += 50);
                button[j].Click += Buttons_Click;
                button[j].Tag = new Point(j);
                MainPanel.Controls.Add(button[j]);
                //MainPanel.Controls[$"Buttons{j}"].Enabled = true;
                
            }
        }

        
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
    public class MyButton : Button
    {
        public static int number;
        public static List<string> _nameButton;
        public static string _answer;
        public MyButton(int i, string name,List<string> nameButton)
        {
            number = i;
            this.Text = name;
            nameButton = _nameButton;
        }
        public int GetNum()
        {

            return number;
        }
        public static string GiveAnAnswer()
        {
            //new MyButton(number, number.ToString());
            List<string> answer = new List<string>();
            answer.Add("Я");
            answer.Add("Я не отвечаю на провокационные");
            answer.Add("Никита");
            answer.Add("Не никита");
            answer.Add("Дима");
            answer.Add("Олег");
            answer.Add("Рома");

            for (int j = 0; j < answer.Count; j++)
            {
                if (j == number && _answer != answer[j])
                {
                    _answer = answer[j];
                    break;
                }
                
            }
            return _answer;

        }
        
      /*  public static void MethodSelection()
        {

            for (int i = 0; i < number; i++)
            {
                if ()
            }
            
        }*/
    }
}
