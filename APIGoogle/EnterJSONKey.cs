using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace APIGoogle
{
    public partial class EnterJSONKey : Form
    {
        public EnterJSONKey()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                Form1 f2 = new Form1(textBox1.Text);
                f2.ShowDialog();
                this.Close();
            }
            
        }
    }
}
