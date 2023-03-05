using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PasswordGenerator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void addValueButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            DataBank.Text = textBox1.Text;
            string txt = DataBank.Text;
            if (txt != "" && DataBank.lang == 0)
            {
                MessageBox.Show("Вы ввели " + DataBank.Text + " элемента(ов) пароля");
                Close();
            }
            else if (txt != "" && DataBank.lang == 1)
            {
                MessageBox.Show("You have entered " + DataBank.Text + " password elements");
                Close();
            }
            else if (txt == "" && DataBank.lang == 0)
            {
                MessageBox.Show("Введите количество элементов пароля!");
            }
            else if (txt == "" && DataBank.lang == 1)
            {
                MessageBox.Show("Enter number of password elements!");
            }
        }
    }
}
