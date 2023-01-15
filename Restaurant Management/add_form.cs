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
using proiect1;

namespace Restaurant_Management
{
    public partial class add_form : Form
    {
        DataBase database = new DataBase(); 
        public add_form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; 
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            database.openConnection();
            var type = textboxtype.Text;
            var count = textboxquantity.Text;
            var seller = textboxseller.Text;
            int price;

            if (int.TryParse(textboxprice.Text, out price))
            {
                var addQuery = $"insert into comenzi (type_of,count_of,distribuitor,price) values('{type}','{count}','{seller}','{price}')";
                var command = new SqlCommand(addQuery, database.GetConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("success!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("error!", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            database.closeConnection(); 

        }
    }
}
