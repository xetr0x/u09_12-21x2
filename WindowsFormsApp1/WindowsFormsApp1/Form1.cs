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
        CalcEngine calc = new CalcEngine();

        public Calc()
        {                                                           
            InitializeComponent();
            textBox1.KeyPress += new KeyPressEventHandler(KeyPressControl);     
            textBox2.KeyPress += new KeyPressEventHandler(KeyPressControl);
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

        private void CalculationHandler(object sender, EventArgs e)         //Den gör själva uträkningarna     
        {
            Button btn = sender as Button;                              //definierar button
            string operation = btn.Text;                            //buttons text
            int i = int.Parse(textBox1.Text);                       //convertar text från textbox1 till int och lägger det som en variabel
            int j = int.Parse(textBox2.Text);
            int answer = 0;                                         //inicierar answer

            try
            {
                switch (operation)
                {
                    case "/":
                        answer = calc.Divide(i, j);             //ansvarar för divison
                        break;

                    case "+":
                        answer =  calc.Add(i, j);               //ansvarar för addition
                        break;

                    case "-":
                        answer = calc.Subtract(i, j);           //ansvarar för substration
                        break;

                    case "*":
                        answer = calc.Multiply(i, j);           //ansvarar för multiplikation
                        break;


                    default:
                        break;
                }

                PresentResult(i, j, answer, operation);         //visar resultat
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Oops, 0 är inte tillåtet");        //visar upp en ruta om talet divideras med noll
                textBox2.Focus();                                   //Lägger som focus till detta bara boxen nummer 2
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


    

