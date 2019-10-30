using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XO
{
    public partial class Form1 : Form
    {
        char J;
        int[,] A;
        int pas;

        public Form1()
        {
            InitializeComponent();
        }

        void colorare()
        {
            int poz=-1;
            int[] p = new int[8];
            p[0] = A[0, 0] * A[0, 1] * A[0, 2];
            p[1] = A[1, 0] * A[1, 1] * A[1, 2];
            p[2] = A[2, 0] * A[2, 1] * A[2, 2];
            p[3] = A[0, 0] * A[1, 0] * A[2, 0];
            p[4] = A[0, 1] * A[1, 1] * A[2, 1];
            p[5] = A[0, 2] * A[1, 2] * A[2, 2];
            p[6] = A[0, 0] * A[1, 1] * A[2, 2];
            p[7] = A[0, 2] * A[1, 1] * A[2, 0];
            for (int i = 0; i < 8; i++)
                if (p[i] == 1 || p[i] == 8) poz = i;
            if(poz==0)
            {  
                button1.BackColor=Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
            }
            if (poz == 1)
            {
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
            }
            if (poz == 2)
            {
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }

            if (poz == 3)
            {
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (poz == 4)
            {
                button2.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button8.BackColor = Color.Red;
            }

            if (poz == 5)
            {
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }

            if (poz == 6)
            {
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }

            if (poz == 7)
            {
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }

        }

        char castigator()
        {
            int[] p=new int[8];
            p[0] = A[0, 0] * A[0, 1] * A[0, 2];
            p[1] = A[1, 0] * A[1, 1] * A[1, 2];
            p[2] = A[2, 0] * A[2, 1] * A[2, 2];
            p[3] = A[0, 0] * A[1, 0] * A[2, 0];
            p[4] = A[0, 1] * A[1, 1] * A[2, 1];
            p[5] = A[0, 2] * A[1, 2] * A[2, 2];
            p[6] = A[0, 0] * A[1, 1] * A[2, 2];
            p[7] = A[0, 2] * A[1, 1] * A[2, 0];
            for (int i = 0; i < 8; i++)
                if (p[i] == 1) return 'X';
                else if (p[i] == 8) return 'O';
            if (pas == 9) return 'E';
            return 'N';
        }

        void reset()
        {
            button10.Enabled = true;
            A = new int[3, 3];
            pas = 0;
            J = 'X';
            button1.Enabled = true;
            button1.Text = "";
            button2.Enabled = true;
            button2.Text = "";
            button3.Enabled = true;
            button3.Text = "";
            button4.Enabled = true;
            button4.Text = "";
            button5.Enabled = true;
            button5.Text = "";
            button6.Enabled = true;
            button6.Text = "";
            button7.Enabled = true;
            button7.Text = "";
            button8.Enabled = true;
            button8.Text = "";
            button9.Enabled = true;
            button9.Text = "";
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
        }

        void muta(int i, int j)
        {
            if (J == 'X')
            {
                J = 'O';
                A[i, j] = 1;
            }
            else
            {
                J = 'X';
                A[i, j] = 2;
            }
            pas++;
            if (castigator() == 'X')
            {
                colorare();
                MessageBox.Show("A castigat X!");
                reset();
            }
            else if (castigator() == 'O')
            {
                colorare();
                MessageBox.Show("A castigat O!");
                reset();
            }
            else if (castigator() == 'E')
            {
                MessageBox.Show("Egalitate!");
                reset();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = J.ToString();
            button1.Enabled = false;
            muta(0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = J.ToString();
            button2.Enabled = false;
            muta(0, 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = J.ToString();
            button3.Enabled = false;
            muta(0, 2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = J.ToString();
            button4.Enabled = false;
            muta(1, 0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = J.ToString();
            button5.Enabled = false;
            muta(1, 1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = J.ToString();
            button6.Enabled = false;
            muta(1, 2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = J.ToString();
            button7.Enabled = false;
            muta(2, 0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = J.ToString();
            button8.Enabled = false;
            muta(2, 1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = J.ToString();
            button9.Enabled = false;
            muta(2, 2);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Enabled = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            A = new int[3, 3];
            J = 'X';
            pas = 0;
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
        }
    }
}
