using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_DS1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //variables
        private string[] numb;
        private int click = 0;
        private string input = string.Empty;
        private string operation;
        private string result = string.Empty;

        //constructor
        public Form1(string input, string operation, string result, string[] numb)
        {
            this.input = input;
            this.operation = operation;
            this.result = result;
            this.numb = numb ?? new string[10];
        }

        //operações
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void btnDividir_Click(object sender, EventArgs e)
        {
            operation = "/";
            lblView.Text = operation;
            input = "";
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            operation = "-";
            lblView.Text = operation;
            input = "";
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            operation = "+";
            lblView.Text = operation;
            input = "";
        }
        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            operation = "*";
            lblView.Text = operation;
            input = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
           lblView.Text = "";

            switch (operation)
            {
                case "+":
                    lblView.Text = "=";
                    break;

                case "-":
                    lblView.Text = "=";
                    break;

                case "/":
                    lblView.Text = "=";
                    break;

                case "*":
                    lblView.Text = "=";
                    break;
            }
                    input = "";
        }
        //botões
        private void btn0_Click(object sender, EventArgs e)
        {
           input = input + 0;
           lblView.Text = input.ToString();
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            input = input + 1;
            lblView.Text = input.ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            input = input + 2;
            lblView.Text = input.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            input = input + 3;
            lblView.Text = input.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            input = input + 4;
            lblView.Text = input.ToString();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            input = input + 5;
            lblView.Text = input.ToString();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            input = input + 6;
            lblView.Text = input.ToString();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            input = input + 7;
            lblView.Text = input.ToString();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            input = input + 8;
            lblView.Text = input.ToString();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            input = input + 9;
            lblView.Text = input.ToString();
        }

        //resultado
        private void label1_Click(object sender, EventArgs e)
        {
        }
        public void tbxResultado_TextChanged(object sender, EventArgs e)
        {
        }

        private void outroMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
