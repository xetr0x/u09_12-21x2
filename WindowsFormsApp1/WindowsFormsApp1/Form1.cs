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
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = int.Parse(textBox1.Text);
            int j = int.Parse(textBox2.Text);
            CalcEngine enging = new CalcEngine();

            int answer = enging.Multiply(i, j);

            listBox1.Items.Add($"{i} * {j} = {answer}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = int.Parse(textBox1.Text);
            int j = int.Parse(textBox2.Text);
            CalcEngine enging = new CalcEngine();

            int answer = enging.Divine(i, j);

            listBox1.Items.Add($"{i} / {j} = {answer}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = int.Parse(textBox1.Text);
            int j = int.Parse(textBox2.Text);
            CalcEngine enging = new CalcEngine();

            int answer = enging.Substract(i, j);

            listBox1.Items.Add($"{i} - {j} = {answer}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = int.Parse(textBox1.Text);
            int j = int.Parse(textBox2.Text);
            CalcEngine enging = new CalcEngine();

            int answer = enging.Add(i, j);

            listBox1.Items.Add($"{i} + {j} = {answer}");
        }
    }
}
