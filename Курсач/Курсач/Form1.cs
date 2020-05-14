using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсач
{
    public partial class Form1 : Form
    {
        public Form1() : base()
        {
            InitializeComponent();
         
        }
    
        enum ats : int
        {
            Абонент_недоступен, Вызов_Абонента
        }
        enum atss : int
        {
            Абонент_недоступен, Связь_установлена, Перезвоните_позже
        }
        Random rnd = new Random();
       
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                listBox1.Items.Add(textBox1.Text);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                listBox1.Items.Remove(textBox1.Text);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button16.Enabled = false;

            label1.Text = "Обработка сигнала";
            label1.Visible = true;
            Thread.Sleep(300);
          
                if(label1.Text != " ")
                {
                
                    ats n = (ats)rnd.Next(2);
                    label1.Text += "\n" + n.ToString();
                       if(n == ats.Абонент_недоступен)
                       {
                    Thread.Sleep(300);
                    label1.Text += "\n" + atss.Перезвоните_позже.ToString();
                       }
                       else
                       {
                    Thread.Sleep(300);
                    atss n1 = (atss)rnd.Next(2);
                    label1.Text += "\n" + n1.ToString();
                    if (n1 == atss.Связь_установлена)
                    {
                        button16.Enabled = true;
                    }
                       }
               
                   
                }
            
          
          
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = "Наберите номер";
            button16.Enabled = false;

        }
    }
}
