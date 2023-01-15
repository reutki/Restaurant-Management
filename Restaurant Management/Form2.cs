using proiect1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Restaurant_Management
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class Form2 : Form
    {
        DataBase dataBase = new DataBase();
        private readonly checkuser _user;

        int selectedRow;


        public Form2(checkuser user)
        {
            _user = user;   
            InitializeComponent();


        }
        private void IsAdmin()
        {
            controlToolStripMenuItem.Enabled = _user.IsAdmin;   
            btnnewquery.Enabled = _user.IsAdmin;
            btndelete.Enabled = _user.IsAdmin;
            btnedit.Enabled = _user.IsAdmin;
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id","id");
            dataGridView1.Columns.Add("type_of", "product type");
            dataGridView1.Columns.Add("count_of", "product count");
            dataGridView1.Columns.Add("distribuitor", "Seller");
            dataGridView1.Columns.Add("price", "price");
            dataGridView1.Columns.Add("IsNew", String.Empty);

        }
            private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0),record.GetString(1),record.GetInt32(2),record.GetString(3),record.GetInt32(4),RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string queryString = $"select * from comenzi";
            SqlCommand command = new SqlCommand(queryString,dataBase.GetConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }
            reader.Close(); 

        }
            private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            clearfields();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void labelleft_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            toolStripTextBox.Text = $"{_user.Login}:{_user.Status}";
            IsAdmin();
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textboxid.Text = row.Cells[0].Value.ToString();
                textboxtype.Text = row.Cells[1].Value.ToString();
                textboxquantity.Text = row.Cells[2].Value.ToString();
                textboxseller.Text = row.Cells[3].Value.ToString();
                textboxprice.Text = row.Cells[4].Value.ToString();
                 

            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            clearfields();
        }

        private void btnnewquery_Click(object sender, EventArgs e)
        {
            add_form addform = new add_form();
            addform.Show();
        }
        private void Search(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string searchString = $"select * from comenzi where concat (id, type_of, count_of, distribuitor, price) like '%" + textboxsearch.Text + "%'";
            SqlCommand command = new SqlCommand(searchString,dataBase.GetConnection());
            dataBase.openConnection();
            SqlDataReader read = command.ExecuteReader();
            while (read.Read()) 
            {
                ReadSingleRow(dgv, read);

            }
            read.Close();
        }
        private void textboxsearch_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }
        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible = false;
            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == String.Empty)
            {
                dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
        }
        private void update()
        {
            dataBase.openConnection();

            for(int index = 0; index<dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[5].Value;
                if (rowState == RowState.Existed)
                {
                    continue;
                }
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deletequery = $"delete from comenzi where id = '{id}'";
                    var command = new SqlCommand(deletequery,dataBase.GetConnection());
                    command.ExecuteNonQuery();  

                }
                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var type = dataGridView1.Rows[index].Cells[1].Value.ToString();

                    var count = dataGridView1.Rows[index].Cells[2].Value.ToString();

                    var seller = dataGridView1.Rows[index].Cells[3].Value.ToString();

                    var price = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    var changeQUERY = $"update comenzi set type_of = '{type}', count_of='{count}',distribuitor='{seller}',price='{price}' where id = '{id}'";
                    var command = new SqlCommand(changeQUERY,dataBase.GetConnection());
                    command.ExecuteNonQuery();
                }

            }
            dataBase.closeConnection();

        }
        private void clearfields()
        {
            textboxid.Text = "";
            textboxprice.Text = "";
            textboxquantity.Text = "";
            textboxtype.Text = "";
            textboxseller .Text = "";

        }
        private void btndelete_Click(object sender, EventArgs e)
        {

            deleteRow();
            clearfields();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            update();
        }
        private void change()
        {

        var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            var id = textboxid.Text;
            var type = textboxtype.Text;
            var count = textboxquantity.Text;
            var seller = textboxseller.Text;
            int price;

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != String.Empty)
            {
                if(int.TryParse(textboxprice.Text,out price))
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(id,type,count,seller,price);
                    dataGridView1.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;

                }
                else
                {
                    MessageBox.Show("the price should be a number!");

                }
            }



        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            change();
            clearfields();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripTextBox_Click(object sender, EventArgs e)
        {

        }
    }


}
