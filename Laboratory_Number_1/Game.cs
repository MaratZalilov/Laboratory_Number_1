using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace Laboratory_Number_1
{

    public partial class Game : Form
    {

        private System.Windows.Forms.Button[] button;
        private List<string> _score = new List<string>();

        private string[,] _answerAndQuestion = null;
        private int _answerNumber = 0;

        Point lastPoint;

        public Game()
        {

            InitializeComponent();
        }
        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }

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
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MainButton_Click(object sender, EventArgs e)
        {
            SecondaryButton();
            
            ReadTheDock();

            AddTextForTheButton();
            MainPanel.Controls.Remove(MainButton);

        }

        private void Buttons_Click(object sender, EventArgs e)
        {
            AddTextForTheButton();
            System.Windows.Forms.Button b = (System.Windows.Forms.Button)sender;
            _score.Add(b.Text);
            _answerNumber++;


        }

        public void SecondaryButton()
        {
            int W = 330, H = 200;
            button = new System.Windows.Forms.Button[3];
            List<string> buttons = new List<string>();
            for (int j = 0; j < 3; j++)
            {
                button[j] = new System.Windows.Forms.Button()
                {
                    BackColor = Color.Orange,
                    Name = $"Buttons" + $"{j}",
                    
                    Size = new Size(200, 50),
                    Location = new Point(W, H += 50),

                };
                button[j].Click += Buttons_Click;
                MainPanel.Controls.Add(button[j]);
            }
        }
        public void AddTextForTheButton()
        {
            if(_answerNumber < 4) 
            {
                for (int i = 1; i < 4; i++)
                {

                    button[i - 1].Text = _answerAndQuestion[_answerNumber, i];


                }
            }
            else
            {
                string str = string.Join(", ", _score); 
                MessageBox.Show(str);
            };
            
        }
        public void ReadTheDock()
        {
            _answerAndQuestion = new string[4,4];
            string name;
            try
            {  
                StreamReader sr = new StreamReader(@"C:\Users\Пользователь\Source\Repos\Laboratory_Number_2\Laboratory_Number_1\QuestionAndAnswer\QuestionAndAnswer.txt");
                    for (int i = 0; i < 4; i++)
                    { 
                    name = sr.ReadLine();
                   
                        _answerAndQuestion[i,0] = name.Split('|')[0];
                        _answerAndQuestion[i,1] = name.Split('/')[1];
                        _answerAndQuestion[i, 2] = name.Split('/')[2];
                        _answerAndQuestion[i, 3] = name.Split('/')[3];
                    };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
