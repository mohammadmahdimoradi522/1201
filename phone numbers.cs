using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.dataDataSet.product);
            // TODO: This line of code loads data into the 'database2DataSet.Members' table. You can move, or remove it, as needed.
            this.membersTableAdapter.Fill(this.database2DataSet.Members);

        }

        private void add_Click(object sender, EventArgs e)
        {
            this.productTableAdapter.InsertQuery1(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
            this.productTableAdapter.Fill(this.dataDataSet.product);

        }
        private void update_Click(object sender, EventArgs e)
        {
            this.productTableAdapter.UpdateQuery(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
            this.productTableAdapter.Fill(this.dataDataSet.product);

        }

        private void Delet_Click(object sender, EventArgs e)
        {
            if (productTableAdapter == null)
            {
                MessageBox.Show("مقداری وارد نشده است");
            }
            else 
            {
                this.productTableAdapter.DeleteQuery(Convert.ToInt32(textBox1.Text));
                this.productTableAdapter.Fill(this.dataDataSet.product);
            }
                

            
        }



       

        

        

       
        


        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void search_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                this.productTableAdapter.Fill(this.dataDataSet.product);
            }
            else
            {

                this.productTableAdapter.FillByname(dataDataSet.product, textBox5.Text);

            }
        }
    }
}
