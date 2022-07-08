using _13_1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_1.View
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            TStatement group1 = new TStatement();
            richTextBox1.Text = group1.ShowStatement();
            richTextBox2.Text = group1.AgeWorker();
            richTextBox3.Text = group1.Staz();
            richTextBox4.Text = group1.Goodjob();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form1 result = new Form1();
            result.Show();
            result.Location = this.Location;
            this.Hide();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                streamWriter.WriteLine("Список работников");
                streamWriter.WriteLine(richTextBox1.Text);
                streamWriter.WriteLine("Работники по возрасту");
                streamWriter.WriteLine(richTextBox2.Text);
                streamWriter.WriteLine(richTextBox3.Text);
                streamWriter.WriteLine("");
                streamWriter.WriteLine("Работники на поощрение");
                streamWriter.WriteLine(richTextBox4.Text);
                streamWriter.Close();
            }
            
        }
    }
}
