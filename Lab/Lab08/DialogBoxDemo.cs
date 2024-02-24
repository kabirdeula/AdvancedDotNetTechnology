using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab08
{
    public partial class DialogBoxDemo : Form
    {
        public DialogBoxDemo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
            textBox1.Font = fontDialog.Font;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            this.BackColor = colorDialog.Color;
        }
    }
}
