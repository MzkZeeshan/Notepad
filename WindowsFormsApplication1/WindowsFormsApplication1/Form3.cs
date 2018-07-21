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
    public partial class Form3 : Form
    {
                Form1 f1;

        public Form3(Form1 ff1)
        {


            f1 = ff1;      
            InitializeComponent();
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "Finf";
            this.label1.Text = "Find What";
            
            this.button1.Text = "Find";
            this.button2.Text = "Cancel";
            this.StartPosition = FormStartPosition.CenterScreen;
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
         if (f1.textBox1.Text.Contains(this.textBox2.Text))
            {
                MessageBox.Show("Find Successfull");
                this.Close();
            }
            else
            {
                MessageBox.Show("No Match Found");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        
        }
        
    }
}
