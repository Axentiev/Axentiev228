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

namespace _15._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo("vbb00k.txt");
            if (file.Exists == false)
            {
                file.Create();
            }
            else
            {
                MessageBox.Show("Файл уже создан");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo("vbbook.txt");
            if (file.Exists == true)
            {
                file.Delete();
            }
            else
            {
                MessageBox.Show("Файл не существует");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader("vbbook.txt");
            while (!streamReader.EndOfStream)
            {
                textBox1.Text += streamReader.ReadLine() + " \r\n";
            }
            streamReader.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StreamWriter write_text;
            FileInfo file = new FileInfo("vbbook.txt");
            write_text = file.AppendText();
            write_text.WriteLine(textBox1.Text);
            write_text.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int sum = 0;
            StreamReader streamReader = new StreamReader("vbbook.txt");
            while(!streamReader.EndOfStream)
            {
                sum += Convert.ToInt32(streamReader.ReadLine() + "\r\n");
            }
            label1.Text = "Сумма цифр в файле равна " + sum.ToString();
            streamReader.Close();
        }
    }
}
