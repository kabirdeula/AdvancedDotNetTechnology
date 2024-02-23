using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e) {
            TextBox textBox = sender as TextBox;
            if (textBox.Name == "textBox1")
            {
                if(textBox.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Cannot leave empty");
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Name == "textBox2")
            {
                if (textBox.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Cannot leave empty");
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Name == "textBox3")
            {
                if (textBox.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Cannot leave empty");
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name= " + textBox1.Text + "\nEmail: " + textBox2.Text + "\nPassword: " + textBox3.Text);
        }
    }
}
