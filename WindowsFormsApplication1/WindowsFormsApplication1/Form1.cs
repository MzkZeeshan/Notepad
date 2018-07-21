using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Zeeshan";
           
           
           this.textBox1.Dock = DockStyle.Fill;
            this.newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            this.openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            this.saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            this.wordwrapToolStripMenuItem.CheckState = CheckState.Checked;
            this.undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            this.textBox1.Font = new Font("", 20);


        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string f_name = openFileDialog1.FileName;
               this.textBox1.Text= File.ReadAllText(f_name);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void wordwrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            if(this.wordwrapToolStripMenuItem.Checked)
            {
                this.wordwrapToolStripMenuItem.CheckState = CheckState.Unchecked;
                this.textBox1.WordWrap = false;
              
            }
            else 
            {
                this.textBox1.WordWrap = true;
               this.wordwrapToolStripMenuItem.CheckState = CheckState.Checked;
            
            }
        }

        private void wordwrapToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
           

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
          DialogResult dr=  this.fontDialog1.ShowDialog();
            if(dr==DialogResult.OK)
            {
                this.textBox1.Font = this.fontDialog1.Font;
            }

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.SelectAll();
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = System.DateTime.Now.ToString();
        }

        private void fontWithColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fontDialog1.ShowColor = true;
            DialogResult dr = this.fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.textBox1.ForeColor = this.fontDialog1.Color;
                this.textBox1.Font = this.fontDialog1.Font;

            }
        }

        private void replaceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "mzk(*.txt) | *.txt";
             DialogResult dr = this.saveFileDialog1.ShowDialog();
             if (dr == DialogResult.OK)
             {

                 string f_name=saveFileDialog1.FileName;
                 File.WriteAllText(f_name , textBox1.Text);
             }
                
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string a = saveFileDialog1.FileName;
            //File.AppendAllText(a, textBox1.Text);
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form2 a = new Form2(this);
            a.Show();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 b = new Form3(this);
            b.Show();
        }
    }
}
