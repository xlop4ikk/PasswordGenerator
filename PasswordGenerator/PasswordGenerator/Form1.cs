using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) // РУС
        {
            DataBank.lang = 0;
            charValueButton.Text = "Количество элементов пароля";
            passwordGeneratorButton.Text = "Сгенерировать пароль";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) // ENG
        {
            DataBank.lang = 1;
            charValueButton.Text = "Number of password elements";
            passwordGeneratorButton.Text = "Generate password";
        }

        private void charValueButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            if (DataBank.lang == 0) // РУС
            {
                form2.label1.Text = "Введите кол-во элементов пароля:";
                form2.addValueButton.Text = "Клик!";
                form2.Show();
            }
            if (DataBank.lang == 1) // ENG
            {
                form2.label1.Text = "Enter the number of password elements:";
                form2.addValueButton.Text = "Click!";
                form2.Show();
            }
        }

        private void passwordGeneratorButton_Click(object sender, EventArgs e) // Алгоритм генерации пароля
        {
            string txt = DataBank.Text;
            int txtInt = Convert.ToInt32(txt);
            // Всего 66 элементов массива
            char[] arr = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '-', '_', '*', '/' };
            string password = null;
            if (txtInt == 0 && DataBank.lang == 0)
            {
                MessageBox.Show("Сначала введите количество элементов пароля!");
            }
            else if (txtInt == 0 && DataBank.lang == 1)
            {
                MessageBox.Show("First enter the number of password elements!");
            }
            else
            {
                Random rnd = new Random();
                for (int i = 0; i < txtInt; i++)
                {
                    password += arr[rnd.Next(0, 65)];
                }
                if (DataBank.lang == 0)
                {
                    MessageBox.Show("Всего " + txt + " элемента(ов) пароля\nВаш пароль: " + password);
                }
                if (DataBank.lang == 1)
                {
                    MessageBox.Show("There are " + txt + " password elements\nYour password: " + password);
                }
            }
        }
    }
}
