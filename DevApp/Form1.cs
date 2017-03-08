using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'classDatabaseDataSet.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.classDatabaseDataSet.Person);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void search_by_Product_NameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.personTableAdapter.Search_by_Product_Name(this.classDatabaseDataSet.Person);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void searchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.personTableAdapter.Search(this.classDatabaseDataSet.Person);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripTextBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void search1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.personTableAdapter.Search1(this.classDatabaseDataSet.Person, productNameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
