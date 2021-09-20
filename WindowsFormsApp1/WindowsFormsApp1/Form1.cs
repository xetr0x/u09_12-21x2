using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calc : Form
    {


        public Calc()
        {
            InitializeComponent();
            CalcEngine calc = new CalcEngine();
            textBox1.KeyPress += new KeyPressEventHandler(KeyPressControl);
            button1.Text = "+";
            button2.Text = "-";
            button3.Text = "/";
            button4.Text = "*";
            button1.Click += new EventHandler(CalculationHandler);
            button2.Click += new EventHandler(CalculationHandler);
            button3.Click += new EventHandler(CalculationHandler);
            button4.Click += new EventHandler(CalculationHandler);
        }


        private void KeyPressControl(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                //Not a number
                //hmm we need to handle Backspace

                //Handled avbryter flödet till textboxen,
                //genom att lura den att det redan är hanterat
                if (((short)e.KeyChar) != 8)
                {
                    e.Handled = true;
                }
            }
        }

        private void CalculationHandler(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string operation = btn.Text;
            int i = int.Parse(textBox1.Text);
            int j = int.Parse(textBox2.Text);
            int answer = 0;

            try
            {
                switch (operation)
                {
                    case "/":
                        answer = CalcEngine.Divide(i, j);
                        break;

                    case "+":
                        answer = CalcEngine.Add(i, j);
                        break;

                    default:
                        break;
                }

                PresentResult(i, j, answer, operation);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Oops, 0 är inte tillåtet");
                textBox2.Focus();
            }
            catch (Exception anka)
            {
                MessageBox.Show("Annat fel: " + anka.Message);
            }
        }
            private static void PresentResult(int i, int j, int answer, string operation)
        {
            MessageBox.Show($"{i} {operation} {j} = {answer}");
        }
    }
}


    

