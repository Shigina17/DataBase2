using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase2
{
    public partial class Form2 : Form
    {
        private string path = "";
        private Form1 form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            timer1.Start();
            this.form1 = form1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sc2.Panel2.BackColor == Color.Coral)
            {
                sc2.Panel2.BackColor = Color.Blue;
            }
            else
            {
                sc2.Panel2.BackColor = Color.Coral;
            }
            
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (e.Node == trGroup.Nodes[0])
            {
                StreamReader sr = new StreamReader("121.txt");
                string[] lines = sr.ReadToEnd().Trim().Split(Convert.ToChar("\n"));
                foreach( string str in lines)
                {
                    dataGridView1.Rows.Add(str.Split());
                }
                sr.Close();
                path = "121.txt";
            }
            else if (e.Node == trGroup.Nodes[1])
            {
                StreamReader sr = new StreamReader("122.txt");
                string[] lines = sr.ReadToEnd().Trim().Split(Convert.ToChar("\n"));
                foreach (string str in lines)
                {
                    dataGridView1.Rows.Add(str.Split());
                }
                sr.Close();
                path = "122.txt";
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (path != "")
            {
                Form3 form = new Form3(path, e.RowIndex, this, form1);
                form.Show();
            }
        }
    }
}
