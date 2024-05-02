using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inquiries
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'names1DataSet.Table1' table. You can move, or remove it, as needed.
            this.table1TableAdapter.Fill(this.names1DataSet.Table1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            table1BindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            table1BindingSource.EndEdit();
            table1TableAdapter.Update(names1DataSet.Table1);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            table1BindingSource.RemoveCurrent();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            table1BindingSource.MoveFirst();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            table1BindingSource.MoveLast();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            table1BindingSource.MovePrevious();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            table1BindingSource.MoveNext();
        }
    }
}
