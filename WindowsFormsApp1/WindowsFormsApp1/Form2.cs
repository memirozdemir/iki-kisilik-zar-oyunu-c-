using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            start1.Visible = false;
            dice1.Visible = false;
            dice2.Visible = false;
            restart.Visible = false;

        }

        private void start2_Click(object sender, EventArgs e)
        {
            restart.Visible = true;
            start2.Visible = false;
            start1.Enabled = true;
            start1.Visible = true;
        }
        int player1sc = 0;
        int player2sc = 0;
        int total1 = 0;
        int total2 = 0;
        private void start1_Click(object sender, EventArgs e)
        {
            dice1.Visible=true;
            dice2.Visible=true;


            Random rnd = new Random();
            player1sc = rnd.Next(1, 7); 
            player2sc = rnd.Next(1, 7);

            dice1.Text = player1sc.ToString();
            dice2.Text = player2sc.ToString();
            
            
            


            if(player1sc ==1)
            {
                pictureBox1.Image = Resource1.dice_six_faces_one;
            }
            if (player1sc == 2)
            {
                pictureBox1.Image = Resource1.dice_six_faces_two;
            }
            if (player1sc == 3)
            {
                pictureBox1.Image = Resource1.dice_six_faces_three;
            }
            if (player1sc == 4)
            {
                pictureBox1.Image = Resource1.dice_six_faces_four;
            }
            if (player1sc == 5)
            {
                pictureBox1.Image = Resource1.dice_six_faces_five;
            }
            if (player1sc == 6)
            {
                pictureBox1.Image = Resource1.dice_six_faces_six;
            }





            if (player2sc == 1)
            {
                pictureBox2.Image = Resource1.dice_six_faces_one;
            }
            if (player2sc == 2)
            {
                pictureBox2.Image = Resource1.dice_six_faces_two;
            }
            if (player2sc == 3)
            {
                pictureBox2.Image = Resource1.dice_six_faces_three;
            }
            if (player2sc == 4)
            {
                pictureBox2.Image = Resource1.dice_six_faces_four;
            }
            if (player2sc == 5)
            {
                pictureBox2.Image = Resource1.dice_six_faces_five;
            }
            if (player2sc == 6)
            {
                pictureBox2.Image = Resource1.dice_six_faces_six;
            }



            total1 = player1sc + total1;
            total2 = player2sc + total2;

            score1.Text = total1.ToString();
            score2.Text = total2.ToString();

            if (total1 >= 100 && total2 >= 100)
            {
                MessageBox.Show("It's a draw, play again.");
                start1.Enabled = false;
            }

            if (total1 >= 100)
            {
                MessageBox.Show("Player 1 won. Congratulations!");
                start1.Enabled = false;
            }
            if (total2 >= 100)
            {
                MessageBox.Show("Player 2 won. Congratulations!");
                start1.Enabled = false;
            }

            




        }

        private void restart_Click(object sender, EventArgs e)
        {
            
            total1 = 0;
            total2 = 0;
            player1sc = 0;
            player2sc = 0;
            score1.Text = "0";
            score2.Text = "0";
            dice1.Text = "0";
            dice2.Text = "0";
            start2.Visible = true;
            start1.Visible = false;
        }
    }
}
