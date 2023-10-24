using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TO_DO_LIST
{
    public partial class ToDolist : Form
    {
        public ToDolist()
        {
            InitializeComponent();
        }

        DataTable todoList = new DataTable();
        bool isEditing = false;
        private void button2_Click(object sender, EventArgs e)
        {
            isEditing = true;
            // Fill text fields with data from table
            titletextBox.Text = todoList.Rows[Todolistview.CurrentCell.RowIndex].ItemArray[0].ToString();
            DescriptiontextBox.Text = todoList.Rows[Todolistview.CurrentCell.RowIndex].ItemArray[1].ToString();
        }

        private void ToDolist_Load(object sender, EventArgs e)
        {
            // Create columns 
            todoList.Columns.Add("Title");
            todoList.Columns.Add("Description");

            // Point our datagridview to our datasource
            Todolistview.DataSource = todoList;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            titletextBox.Text = "";
            DescriptiontextBox.Text = "";
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                todoList.Rows[Todolistview.CurrentCell.RowIndex].Delete();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            
            }


        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                todoList.Rows[Todolistview.CurrentCell.RowIndex]["Title"] = titletextBox.Text;
                todoList.Rows[Todolistview.CurrentCell.RowIndex]["Description"] = DescriptiontextBox.Text;
            }
            else
            {
                todoList.Rows.Add(titletextBox.Text, DescriptiontextBox.Text);
            }
            // Clear Fields
            titletextBox.Text = "";
            DescriptiontextBox.Text = "";
            isEditing = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            //-----------------------------------------
            if (this.usernametextBox1.Text == "")
            {
                MessageBox.Show("UserName is Empty!!!");
                return;
            }
            //--------------------------------------------
            if (this.PasstextBox2.Text!=this.Pass_confirmtextBox3.Text)
            {
                MessageBox.Show("You must enter same password in both textboxes!");
                return;

            }
        }

        private void titletextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
