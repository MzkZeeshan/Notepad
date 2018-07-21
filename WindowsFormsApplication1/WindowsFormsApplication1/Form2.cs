using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        Form1 aa;

        public Form2(Form1 a)
        {
            InitializeComponent();
            aa = a;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "Relace";
            this.label1.Text = "Find What";
            this.label2.Text = "Replace With";
            this.button1.Text = "Replace";
            this.button2.Text = "Cancel";


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          aa.textBox1.Text=  aa.textBox1.Text.Replace(this.textBox1.Text, this.textBox2.Text);

           //aaa.textBox1.Text = aaa.textBox1.Text.Replace(this.textBox1.Text, this.textBox2.Text);
         
        }
    }
}
