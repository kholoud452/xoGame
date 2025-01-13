namespace XOGameLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int count = 0;
        void fnsymbol(object senderobj)
        {
            string btn_text = (senderobj as Button).Text;
            if (btn_text == "")
            {
                if (count % 2 == 0)
                    (senderobj as Button).Text = "O";
                else
                    (senderobj as Button).Text = "X";
                count++;

                checkWinner("O",senderobj);

                checkWinner("X",senderobj);
            }
            else
                MessageBox.Show("Invalid Click");
        }
        void RestartGame()
        {
            Application.Restart();
        }
        
        void checkWinner(string symbol,object obj)
        {
            if(button1.Text==symbol &&  button2.Text==symbol && button3.Text==symbol)
            {
                MessageBox.Show($"Player ({symbol}) win");
                RestartGame();
            }
            else if (button4.Text == symbol && button5.Text == symbol && button6.Text == symbol)
            {
                MessageBox.Show($"Player ({symbol}) win");
                RestartGame();
            }
            else if (button7.Text == symbol && button8.Text == symbol && button9.Text == symbol)
            {
                MessageBox.Show($"Player ({symbol}) win");
                RestartGame();
            }
            else if (button1.Text == symbol && button5.Text == symbol && button9.Text == symbol)
            {
                MessageBox.Show($"Player ({symbol}) win");
                RestartGame();
            }
            else if (button3.Text == symbol && button5.Text == symbol && button7.Text == symbol)
            {
                MessageBox.Show($"Player ({symbol}) win");
                RestartGame();
            }
            else if (button2.Text == symbol && button5.Text == symbol && button8.Text == symbol)
            {
                MessageBox.Show($"Player ({symbol}) win");
                RestartGame();
            }
            else if (button3.Text == symbol && button6.Text == symbol && button9.Text == symbol)
            {
                MessageBox.Show($"Player ({symbol}) win");
                RestartGame();
            }
            else if (button1.Text == symbol && button4.Text == symbol && button7.Text == symbol)
            {
                MessageBox.Show($"Player ({symbol}) win");
                RestartGame();
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
        }
    }
}
