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

namespace DataBase2
{
    public partial class Form3 : Form
    {
        private string path;
        private int index;
        private string[] data;
        private Form2 parent;
        private Form1 grandparent;

        public Form3(string path, int index, Form2 parent, Form1 grandparent)
        {
            InitializeComponent();
            this.path = path;
            this.index = index;
            this.parent = parent;
            this.grandparent = grandparent;
            StreamReader sr = new StreamReader(path);
            data = sr.ReadToEnd().Trim().Split(Convert.ToChar("\n"));
            sr.Close();
            string[] line = data[index].Trim().Split();
            textBox1.Text = line[0];
            textBox2.Text = line[1];
            textBox3.Text = line[2];
            checkBox1.Checked = Convert.ToBoolean(line[3]);
            if (path == "121.txt")
            {
                pictureBox1.Image = DataBase2.Properties.Resources.картинка1;
            }
            else
            {
                pictureBox1.Image = DataBase2.Properties.Resources.картинка2;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(path);
            data[index] = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + checkBox1.Checked.ToString();
            sw.Write(String.Join("\n", data));
            sw.Close();
            parent.Close();
            grandparent.Close();
            this.Close();
        }
    }
}
