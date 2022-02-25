using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // установка начального адреса
            webBrowser1.Url = new Uri("http://google.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
                Form2 newForm = new Form2(this); //создаем объект класса, this Для управления между формами
                newForm.Show();
        }
    }
}
