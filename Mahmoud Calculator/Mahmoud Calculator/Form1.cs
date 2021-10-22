using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Mahmoud_Calculator
{
    public partial class Simple_Calculator : Form
    {
        double firstdigit = 0;
        bool IS_Opreation_Done = false;
        string OperationSign = "";
        public Simple_Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if ((InputBox.Text == "0") || (IS_Opreation_Done)) { 
                InputBox.Clear();
            }
            IS_Opreation_Done = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!InputBox.Text.Contains("."))
                    InputBox.Text = InputBox.Text + button.Text;
            }
            else
                InputBox.Text = InputBox.Text + button.Text;
            
            //InputBox.Text = button.Text;  
        }

        private void Operations(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            OperationSign = button.Text;
            firstdigit = Double.Parse(InputBox.Text);
            IS_Opreation_Done = true;
            InputBox.Text = firstdigit + " " + OperationSign;
            labelCurrentOpeation.Text = firstdigit + " " + OperationSign;
        }

        private void Clear(object sender, EventArgs e)
        {
            InputBox.Text = "0";
            firstdigit = 0;
            labelCurrentOpeation.Text = "";
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            switch (OperationSign)
            {
                case "+":
                    InputBox.Text = (firstdigit + (Double.Parse(InputBox.Text))).ToString();
                    break;
                case "-":
                    InputBox.Text = (firstdigit - (Double.Parse(InputBox.Text))).ToString();
                    break;
                case "/":
                    InputBox.Text = (firstdigit / (Double.Parse(InputBox.Text))).ToString();
                    break;
                case "*":
                    InputBox.Text = (firstdigit * (Double.Parse(InputBox.Text))).ToString();
                    break;
               
                default:
                    break;
            }
       
        }

        private void Backspace(object sender, EventArgs e)
        {
            int index = InputBox.Text.Length;
            index--;
            InputBox.Text = InputBox.Text.Remove(index);
            if (InputBox.Text == "")
            {
                InputBox.Text = "0";
            }
        }

        private void button_Puls_Sub(object sender, EventArgs e)
        {
            firstdigit = double.Parse(InputBox.Text);
            firstdigit = firstdigit * -1;
            InputBox.Text = firstdigit.ToString();
        }

        private void button_Click(object sender, EventArgs e)
        {
            firstdigit = double.Parse(InputBox.Text);
            firstdigit = firstdigit / 100;
            InputBox.Text = firstdigit.ToString();
        }

        private void THis(object sender, EventArgs e)
        {

        }

        
    }
}
